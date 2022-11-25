using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortaalBackend.Business.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Assignment_AssignmentId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_AssignmentId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Tag");

            migrationBuilder.CreateTable(
                name: "AssignmentTag",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTag", x => new { x.AssignmentId, x.TagId });
                    table.ForeignKey(
                        name: "FK_AssignmentTag_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentTag_TagId",
                table: "AssignmentTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentTag");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_AssignmentId",
                table: "Tag",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Assignment_AssignmentId",
                table: "Tag",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id");
        }
    }
}
