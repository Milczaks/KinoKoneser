using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 1,
                column: "title",
                value: "AAA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 1,
                column: "title",
                value: "AA");
        }
    }
}
