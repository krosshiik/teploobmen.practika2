using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teploob.Migrations
{
    public partial class TableInputDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InputDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    H = table.Column<double>(type: "REAL", nullable: false),
                    Tmaterial = table.Column<double>(type: "REAL", nullable: false),
                    Tgaza = table.Column<double>(type: "REAL", nullable: false),
                    Vgaza = table.Column<double>(type: "REAL", nullable: false),
                    Cgaza = table.Column<double>(type: "REAL", nullable: false),
                    Rashod = table.Column<double>(type: "REAL", nullable: false),
                    Gmaterial = table.Column<double>(type: "REAL", nullable: false),
                    AV = table.Column<double>(type: "REAL", nullable: false),
                    Dapparata = table.Column<double>(type: "REAL", nullable: false),
                    DateAdd = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputDatas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputDatas");
        }
    }
}
