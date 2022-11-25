using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortaalBackend.Business.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Comment_AssignmentId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Comment");

            migrationBuilder.CreateTable(
                name: "AssignmentComments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentComments", x => new { x.AssignmentId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_AssignmentComments_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentComments_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AssignmentComments_CommentId",
                table: "AssignmentComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentTags_TagId",
                table: "AssignmentTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentComments");

            migrationBuilder.DropTable(
                name: "AssignmentTags");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_AssignmentId",
                table: "Tag",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AssignmentId",
                table: "Comment",
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
