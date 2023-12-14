using BookWeb.DataAccess.Data;
using BookWeb.DataAccess.Repository.IRepository;
using BookWeb.Models;
using BookWeb.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Areas.Admins.Controllers
{
    [Area("Admins")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Categories()
        {
            List<Category> categories = _unitOfWork.Category.GetAll().ToList();

            if (categories.Count == 0)
            {
                return NotFound();
            }

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category ojb)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Category.Add(ojb);
                _unitOfWork.Save();
                TempData["success"] = "A new category has been created";
                return RedirectToAction("Categories");
            }
            return View();
        }

        public IActionResult Update(Guid Id)
        {
            Category category = _unitOfWork.Category.Get(c => c.Id == Id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category ojb)
        {
            _unitOfWork.Category.Update(ojb);
            _unitOfWork.Save();

            TempData["success"] = "A category has been updated";
            return RedirectToAction("Categories");
        }

        public IActionResult Delete(Guid Id)
        {
            Category category = _unitOfWork.Category.Get(c => c.Id == Id);
            if (category == null)
            {
                return NotFound();
            }

            TempData["success"] = "A category has been deleted";
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category ojb)
        {
            Category category = _unitOfWork.Category.Get(c => c.Id == ojb.Id);
            if (category == null)
            {
                return NotFound();
            }

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();

            return RedirectToAction("Categories");
        }
    }
}
