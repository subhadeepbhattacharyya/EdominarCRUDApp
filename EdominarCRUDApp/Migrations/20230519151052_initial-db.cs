using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdominarCRUDApp.Migrations
{
    /// <inheritdoc />
    public partial class initialdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Football" },
                    { 2, "Movie Binge" },
                    { 3, "Reading" },
                    { 4, "Music" },
                    { 5, "Photography" },
                    { 6, "Cooking" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Andhra Pradesh" },
                    { 2, "Arunachal Pradesh" },
                    { 3, "Assam" },
                    { 4, "Bihar" },
                    { 5, "Chhattisgarh" },
                    { 6, "Goa" },
                    { 7, "Gujarat" },
                    { 8, "Haryana" },
                    { 9, "Himachal Pradesh" },
                    { 10, "Jammu and Kashmir" },
                    { 11, "Jharkhand" },
                    { 12, "Karnataka" },
                    { 13, "Kerala" },
                    { 14, "Madhya Pradesh" },
                    { 15, "Maharashtra" },
                    { 16, "Manipur" },
                    { 17, "Meghalaya" },
                    { 18, "Mizoram" },
                    { 19, "Nagaland" },
                    { 20, "Odisha" },
                    { 21, "Punjab" },
                    { 22, "Rajasthan" },
                    { 23, "Sikkim" },
                    { 24, "Tamil Nadu" },
                    { 25, "Telangana" },
                    { 26, "Tripura" },
                    { 27, "Uttarakhand" },
                    { 28, "Uttar Pradesh" },
                    { 29, "West Bengal" },
                    { 30, "Andaman and Nicobar Islands" },
                    { 31, "Chandigarh" },
                    { 32, "Dadra and Nagar Haveli" },
                    { 33, "Daman and Diu" },
                    { 34, "Delhi" },
                    { 35, "Lakshadweep" },
                    { 36, "Puducherry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
