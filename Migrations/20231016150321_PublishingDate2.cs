using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ciurca_Radu_Lab2.Migrations
{
    public partial class PublishingDate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Book",
                newName: "PublishingDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishingDate",
                table: "Book",
                newName: "Date");
        }
    }
}
