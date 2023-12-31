﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finance.Domain.Migrations
{
    public partial class CategoryTypeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Categories");
        }
    }
}
