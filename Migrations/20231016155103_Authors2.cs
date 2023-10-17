﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ciurca_Radu_Lab2.Migrations
{
    public partial class Authors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Author",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Author",
                newName: "AuthorName");
        }
    }
}