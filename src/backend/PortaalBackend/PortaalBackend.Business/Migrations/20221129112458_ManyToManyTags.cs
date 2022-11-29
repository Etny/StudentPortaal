using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortaalBackend.Business.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Assignment_AssignmentId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Assignment_AssignmentId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_AssignmentId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AssignmentTags",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTags", x => new { x.AssignmentId, x.TagId });
                    table.ForeignKey(
                        name: "FK_AssignmentTags_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentTags_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentTags_TagId",
                table: "AssignmentTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Assignment_AssignmentId",
                table: "Comment",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Assignment_AssignmentId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "AssignmentTags");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "Comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_AssignmentId",
                table: "Tag",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Assignment_AssignmentId",
                table: "Comment",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Assignment_AssignmentId",
                table: "Tag",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id");
        }
    }
}
