using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Data.Migrations
{
    /// <inheritdoc />
    public partial class ajhsdjahsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Companies",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Departments",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CompanyId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_DepartmentId",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CompanyId_DepartmentId",
                table: "Tasks",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompaniesToDepartments_Tasks",
                table: "Tasks",
                columns: new[] { "CompanyId", "DepartmentId" },
                principalTable: "CompaniesToDepartments",
                principalColumns: new[] { "CompanyId", "DepartmentId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompaniesToDepartments_Tasks",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CompanyId_DepartmentId",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CompanyId",
                table: "Tasks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DepartmentId",
                table: "Tasks",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Companies",
                table: "Tasks",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Departments",
                table: "Tasks",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
