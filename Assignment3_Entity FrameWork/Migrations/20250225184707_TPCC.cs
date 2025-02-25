using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_Entity_FrameWork.Migrations
{
    public partial class TPCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FullTimeEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    decimal103 = table.Column<decimal>(name: "decimal(10,3)", type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeEmployee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartTimeEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountOfHours = table.Column<int>(type: "int", nullable: false),
                    decimal52 = table.Column<decimal>(name: "decimal(5,2)", type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimeEmployee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeEmployee");

            migrationBuilder.DropTable(
                name: "PartTimeEmployee");
        }
    }
}
