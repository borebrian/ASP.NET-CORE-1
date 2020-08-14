using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fuela_clients.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MyProperty",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedon",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "updatedon",
                table: "Books");
        }
    }
}
