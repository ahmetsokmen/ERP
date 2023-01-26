using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskMedia",
                table: "TaskMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentMedia",
                table: "CommentMedia");

            migrationBuilder.RenameTable(
                name: "TaskMedia",
                newName: "TaskMedias");

            migrationBuilder.RenameTable(
                name: "CommentMedia",
                newName: "CommentMedias");

            migrationBuilder.RenameIndex(
                name: "IX_TaskMedia_TaskId",
                table: "TaskMedias",
                newName: "IX_TaskMedias_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentMedia_TaskCommentId",
                table: "CommentMedias",
                newName: "IX_CommentMedias_TaskCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskMedias",
                table: "TaskMedias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentMedias",
                table: "CommentMedias",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EmployeesToCompanies",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesToCompanies", x => new { x.EmployeeId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_EmployeesToCompaines_Compaines",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesToCompaines_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesToCompanies_CompanyId",
                table: "EmployeesToCompanies",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesToCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskMedias",
                table: "TaskMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentMedias",
                table: "CommentMedias");

            migrationBuilder.RenameTable(
                name: "TaskMedias",
                newName: "TaskMedia");

            migrationBuilder.RenameTable(
                name: "CommentMedias",
                newName: "CommentMedia");

            migrationBuilder.RenameIndex(
                name: "IX_TaskMedias_TaskId",
                table: "TaskMedia",
                newName: "IX_TaskMedia_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentMedias_TaskCommentId",
                table: "CommentMedia",
                newName: "IX_CommentMedia_TaskCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskMedia",
                table: "TaskMedia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentMedia",
                table: "CommentMedia",
                column: "Id");
        }
    }
}
