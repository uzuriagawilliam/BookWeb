using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class filesCopied : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00070392-77f9-4c6e-945f-326fac2f6b5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46e1467f-0169-452e-9d93-4f7ffd1f8996"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d455dda-7218-4cc8-9d1c-9dcc3377a594"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50cbefdf-84c5-4248-86a8-3cddeb898805"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9710e352-d1b8-4125-8ba5-677e21c24c24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f84b758b-c707-4f13-83af-51126a9cbe69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5189dce6-6a58-47a8-b32b-e40e6b9ba71c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("955299b0-8cf2-4f3c-8b5f-9b2c26b9fdad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a12263c1-604d-40b1-bf44-14b75fc3bcce"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("0d40cffa-286a-456b-9ff7-ccc970d27046"), 2, "Drama" },
                    { new Guid("5bf26890-cfc6-4d07-b4b6-a8735af98161"), 3, "Thriller" },
                    { new Guid("ac4dc0f0-85ca-434b-a25d-2707edf1c49b"), 1, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("2d2afde3-08b3-4a2a-aff7-31ab9cac84fe"), "Laura Phantom", new Guid("ac4dc0f0-85ca-434b-a25d-2707edf1c49b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("3ea38166-cb87-445d-9fa6-cd2a3285b166"), "Nancy Hoover", new Guid("5bf26890-cfc6-4d07-b4b6-a8735af98161"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("64b38fa5-b6f2-45b0-b082-1d4bd2720d4d"), "Ron Parker", new Guid("5bf26890-cfc6-4d07-b4b6-a8735af98161"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("7a3e242f-a80d-443d-bf35-1d715c7991d7"), "Abby Muscles", new Guid("0d40cffa-286a-456b-9ff7-ccc970d27046"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { new Guid("deaeb06c-389a-4077-8423-205f948efd88"), "Billy Spark", new Guid("0d40cffa-286a-456b-9ff7-ccc970d27046"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("f121028d-f897-4317-a34b-64ab47bb09f4"), "Julian Button", new Guid("ac4dc0f0-85ca-434b-a25d-2707edf1c49b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d2afde3-08b3-4a2a-aff7-31ab9cac84fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ea38166-cb87-445d-9fa6-cd2a3285b166"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b38fa5-b6f2-45b0-b082-1d4bd2720d4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a3e242f-a80d-443d-bf35-1d715c7991d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deaeb06c-389a-4077-8423-205f948efd88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f121028d-f897-4317-a34b-64ab47bb09f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d40cffa-286a-456b-9ff7-ccc970d27046"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bf26890-cfc6-4d07-b4b6-a8735af98161"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac4dc0f0-85ca-434b-a25d-2707edf1c49b"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("5189dce6-6a58-47a8-b32b-e40e6b9ba71c"), 3, "Thriller" },
                    { new Guid("955299b0-8cf2-4f3c-8b5f-9b2c26b9fdad"), 2, "Drama" },
                    { new Guid("a12263c1-604d-40b1-bf44-14b75fc3bcce"), 1, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("00070392-77f9-4c6e-945f-326fac2f6b5c"), "Ron Parker", new Guid("5189dce6-6a58-47a8-b32b-e40e6b9ba71c"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("46e1467f-0169-452e-9d93-4f7ffd1f8996"), "Laura Phantom", new Guid("a12263c1-604d-40b1-bf44-14b75fc3bcce"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("4d455dda-7218-4cc8-9d1c-9dcc3377a594"), "Julian Button", new Guid("a12263c1-604d-40b1-bf44-14b75fc3bcce"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("50cbefdf-84c5-4248-86a8-3cddeb898805"), "Nancy Hoover", new Guid("5189dce6-6a58-47a8-b32b-e40e6b9ba71c"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("9710e352-d1b8-4125-8ba5-677e21c24c24"), "Billy Spark", new Guid("955299b0-8cf2-4f3c-8b5f-9b2c26b9fdad"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("f84b758b-c707-4f13-83af-51126a9cbe69"), "Abby Muscles", new Guid("955299b0-8cf2-4f3c-8b5f-9b2c26b9fdad"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" }
                });
        }
    }
}
