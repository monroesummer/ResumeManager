using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumeManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    HRLastName = table.Column<string>(nullable: false),
                    HRName = table.Column<string>(nullable: false),
                    HRPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birthdate = table.Column<string>(nullable: false),
                    CASE = table.Column<string>(nullable: false),
                    Career = table.Column<string>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    Complexity = table.Column<string>(nullable: false),
                    Database = table.Column<string>(nullable: false),
                    Education = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    FillingDate = table.Column<string>(nullable: false),
                    Hobby = table.Column<string>(nullable: false),
                    Home = table.Column<string>(nullable: false),
                    Intensity = table.Column<string>(nullable: false),
                    Knowledge = table.Column<string>(nullable: false),
                    Language = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Mark = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: false),
                    Money = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Network = table.Column<string>(nullable: false),
                    OS = table.Column<string>(nullable: false),
                    PL = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    PreferSalary = table.Column<string>(nullable: false),
                    Prestige = table.Column<string>(nullable: false),
                    Stability = table.Column<string>(nullable: false),
                    TeamDev = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitors_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CompanyId",
                table: "Competitors",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
