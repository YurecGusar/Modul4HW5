using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW5.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Budget = table.Column<decimal>(type: "money", nullable: false),
                    StartedTime = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredData = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    DataOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmployeeProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(type: "money", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.EmployeeProjectId);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "DataOfBirth", "DateOfRegistration", "FirstName", "SecondName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(493), "Ivan", "Budko" },
                    { 2, null, new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(876), "Dmitro", "Burunko" },
                    { 3, new DateTime(2001, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1198), "Yurii", "Leonov" },
                    { 4, new DateTime(2000, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1215), "Andry", "Kust" },
                    { 5, new DateTime(2014, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1218), "Misha", "Krutoy" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "asfafasf", "asaaaswd" },
                    { 2, "qwert", "lkgfd" },
                    { 3, "sss", "aaa" },
                    { 4, "ggg", "sddfg" },
                    { 5, "hgfgr", "vcbcvb" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "qwerty" },
                    { 2, "fdsgrs" },
                    { 3, "fdgkjjgf" },
                    { 4, "asdfg" },
                    { 5, "zxcvbn" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DataOfBirth", "FirstName", "HiredData", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tatur", new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), " ", 1, 1 },
                    { 2, new DateTime(1999, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vlad", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladov", 2, 2 },
                    { 3, new DateTime(1990, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stepanov", 3, 3 },
                    { 4, new DateTime(1954, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fedorov", 4, 4 },
                    { 5, new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", new DateTime(2010, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedTime" },
                values: new object[,]
                {
                    { 1, 12345m, 1, "First", new DateTime(2001, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 12345m, 2, "Second", new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12345m, 3, "qqq", new DateTime(2001, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 12345m, 4, "ddd", new DateTime(2001, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 12345m, 5, "dssfs", new DateTime(2021, 9, 8, 13, 35, 20, 574, DateTimeKind.Local).AddTicks(3069) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 4, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 5, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_ProjectId",
                table: "EmployeeProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OfficeId",
                table: "Employees",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TitleId",
                table: "Employees",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
