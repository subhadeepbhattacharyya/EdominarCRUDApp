using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EdominarCRUDApp.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Painting" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
