using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AmineV02.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gaeste",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ankunft = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: false),
                    Nachname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Wunsch = table.Column<string>(nullable: false),
                    vegan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gaeste", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gaeste");
        }
    }
}
