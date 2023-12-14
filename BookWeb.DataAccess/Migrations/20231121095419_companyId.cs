using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class companyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3c4b98-fe1d-4d5c-8cbe-f7264457c782"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d84d648-447b-4ea2-88f2-a9f762abe2c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbd98995-fc5c-49e3-a724-0636a4b11025"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d822d6e1-9d7b-4523-a4a0-9b9e237f6f59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e22986ca-0ba0-47c2-acd8-e45716414e3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f73c8191-38a9-4d86-80f8-d1a44a01e0e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acfe61b6-7763-4962-b1c7-9bbab67d834b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cba4776f-824d-4be1-a3c9-3e027508069b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fac995b1-828d-43c7-baf8-57c9ca909201"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("01297947-0749-4bb2-8c94-e50a1b0b8555"), 3, "Thriller" },
                    { new Guid("584bd41a-a1df-47fc-8458-ad61b780bddd"), 2, "Drama" },
                    { new Guid("c6533f72-7ce8-4c00-b99c-f4e13333d5e8"), 1, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("065ba000-d212-48bc-bb39-a96366de0e75"), "Nancy Hoover", new Guid("01297947-0749-4bb2-8c94-e50a1b0b8555"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("3527a3a9-4ba4-48c0-9fd7-594ff28ff666"), "Abby Muscles", new Guid("584bd41a-a1df-47fc-8458-ad61b780bddd"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { new Guid("4c596027-a949-4c7d-adcd-52430a880312"), "Laura Phantom", new Guid("c6533f72-7ce8-4c00-b99c-f4e13333d5e8"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("4e1c7538-a281-4b53-bcea-f463ecdb08c2"), "Ron Parker", new Guid("01297947-0749-4bb2-8c94-e50a1b0b8555"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("d170e182-b39c-4e53-8d7a-eaff00fe6bae"), "Julian Button", new Guid("c6533f72-7ce8-4c00-b99c-f4e13333d5e8"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("d42ad890-2eb1-4eea-943b-c66b51ab253e"), "Billy Spark", new Guid("584bd41a-a1df-47fc-8458-ad61b780bddd"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("065ba000-d212-48bc-bb39-a96366de0e75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3527a3a9-4ba4-48c0-9fd7-594ff28ff666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c596027-a949-4c7d-adcd-52430a880312"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e1c7538-a281-4b53-bcea-f463ecdb08c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d170e182-b39c-4e53-8d7a-eaff00fe6bae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d42ad890-2eb1-4eea-943b-c66b51ab253e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01297947-0749-4bb2-8c94-e50a1b0b8555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("584bd41a-a1df-47fc-8458-ad61b780bddd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6533f72-7ce8-4c00-b99c-f4e13333d5e8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("acfe61b6-7763-4962-b1c7-9bbab67d834b"), 2, "Drama" },
                    { new Guid("cba4776f-824d-4be1-a3c9-3e027508069b"), 3, "Thriller" },
                    { new Guid("fac995b1-828d-43c7-baf8-57c9ca909201"), 1, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("1e3c4b98-fe1d-4d5c-8cbe-f7264457c782"), "Abby Muscles", new Guid("acfe61b6-7763-4962-b1c7-9bbab67d834b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { new Guid("7d84d648-447b-4ea2-88f2-a9f762abe2c6"), "Nancy Hoover", new Guid("cba4776f-824d-4be1-a3c9-3e027508069b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("bbd98995-fc5c-49e3-a724-0636a4b11025"), "Julian Button", new Guid("fac995b1-828d-43c7-baf8-57c9ca909201"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("d822d6e1-9d7b-4523-a4a0-9b9e237f6f59"), "Billy Spark", new Guid("acfe61b6-7763-4962-b1c7-9bbab67d834b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("e22986ca-0ba0-47c2-acd8-e45716414e3f"), "Laura Phantom", new Guid("fac995b1-828d-43c7-baf8-57c9ca909201"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("f73c8191-38a9-4d86-80f8-d1a44a01e0e6"), "Ron Parker", new Guid("cba4776f-824d-4be1-a3c9-3e027508069b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" }
                });
        }
    }
}
