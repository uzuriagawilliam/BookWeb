using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCountryToApplictionUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("016a2289-5967-4ec8-b773-5d7b9160c967"), 1, "Action" },
                    { new Guid("83cced20-17ec-4cd9-aa4f-48d7c2344e19"), 2, "Drama" },
                    { new Guid("decb1121-6991-44e2-ba86-aef86ad48280"), 3, "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("1f6cb56f-3f22-463a-a497-b0c9e1333068"), "Billy Spark", new Guid("83cced20-17ec-4cd9-aa4f-48d7c2344e19"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("4992891f-bfb6-4f2a-b1c8-9c70ffd0cfc7"), "Julian Button", new Guid("016a2289-5967-4ec8-b773-5d7b9160c967"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("5da197a7-4b66-4bac-b337-d094cf42321b"), "Abby Muscles", new Guid("83cced20-17ec-4cd9-aa4f-48d7c2344e19"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { new Guid("7a27aec8-9463-4c0f-af89-05790e6d774d"), "Laura Phantom", new Guid("016a2289-5967-4ec8-b773-5d7b9160c967"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("b08de145-b80a-41ee-a5d9-67abff383fce"), "Ron Parker", new Guid("decb1121-6991-44e2-ba86-aef86ad48280"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("f227dad3-e17c-486f-a863-2b1dda6752fe"), "Nancy Hoover", new Guid("decb1121-6991-44e2-ba86-aef86ad48280"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6cb56f-3f22-463a-a497-b0c9e1333068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4992891f-bfb6-4f2a-b1c8-9c70ffd0cfc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5da197a7-4b66-4bac-b337-d094cf42321b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a27aec8-9463-4c0f-af89-05790e6d774d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b08de145-b80a-41ee-a5d9-67abff383fce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f227dad3-e17c-486f-a863-2b1dda6752fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("016a2289-5967-4ec8-b773-5d7b9160c967"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83cced20-17ec-4cd9-aa4f-48d7c2344e19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("decb1121-6991-44e2-ba86-aef86ad48280"));

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

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
        }
    }
}
