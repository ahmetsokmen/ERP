using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskComments_TaskMedias",
                table: "TaskMedia");

            migrationBuilder.DropTable(
                name: "SubTasksMedias");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.RenameColumn(
                name: "TaskCommentId",
                table: "TaskMedia",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskMedia_TaskCommentId",
                table: "TaskMedia",
                newName: "IX_TaskMedia_TaskId");

            migrationBuilder.RenameColumn(
                name: "EvulationStatus",
                table: "TaskEvaluations",
                newName: "EvaluationStatus");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EvaluationDescription",
                table: "TaskEvaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CommentMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskCommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskComments_CommentMedias",
                        column: x => x.TaskCommentId,
                        principalTable: "TaskComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentMedia_TaskCommentId",
                table: "CommentMedia",
                column: "TaskCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskMedias",
                table: "TaskMedia",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedTasks_Employees",
                table: "Tasks",
                column: "OwnerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskMedias",
                table: "TaskMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnedTasks_Employees",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "CommentMedia");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EvaluationDescription",
                table: "TaskEvaluations");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TaskMedia",
                newName: "TaskCommentId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskMedia_TaskId",
                table: "TaskMedia",
                newName: "IX_TaskMedia_TaskCommentId");

            migrationBuilder.RenameColumn(
                name: "EvaluationStatus",
                table: "TaskEvaluations",
                newName: "EvulationStatus");

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTasks_Tasks",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTasksMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasksMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTasksMedias_SubTasks",
                        column: x => x.SubTaskId,
                        principalTable: "SubTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TaskId",
                table: "SubTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasksMedias_SubTaskId",
                table: "SubTasksMedias",
                column: "SubTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskComments_TaskMedias",
                table: "TaskMedia",
                column: "TaskCommentId",
                principalTable: "TaskComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
