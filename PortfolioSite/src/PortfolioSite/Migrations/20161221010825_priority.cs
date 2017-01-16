using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioSite.Migrations
{
    public partial class priority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "priority",
                table: "Projects",
                newName: "Priority");

            migrationBuilder.AddColumn<string>(
                name: "ProductLink",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {       

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Projects",
                newName: "priority");

            migrationBuilder.DropColumn(
                 name: "ProductLink",
                 table: "Projects");
        }
    }
}
