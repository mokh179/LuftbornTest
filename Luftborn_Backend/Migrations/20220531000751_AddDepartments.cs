using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luftborn.Migrations
{
    public partial class AddDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentStudent");

            migrationBuilder.DropTable(
                name: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentStudent",
                columns: table => new
                {
                    departmentsId = table.Column<int>(type: "int", nullable: false),
                    studentsstudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentStudent", x => new { x.departmentsId, x.studentsstudentId });
                    table.ForeignKey(
                        name: "FK_DepartmentStudent_Departments_departmentsId",
                        column: x => x.departmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentStudent_Students_studentsstudentId",
                        column: x => x.studentsstudentId,
                        principalTable: "Students",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentStudent_studentsstudentId",
                table: "DepartmentStudent",
                column: "studentsstudentId");
        }
    }
}
