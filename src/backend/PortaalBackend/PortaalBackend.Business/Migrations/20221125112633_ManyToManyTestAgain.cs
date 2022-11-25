using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortaalBackend.Business.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyTestAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentTag_Assignment_AssignmentId",
                table: "AssignmentTag");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentTag_Tag_TagId",
                table: "AssignmentTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentTag",
                table: "AssignmentTag");

            migrationBuilder.RenameTable(
                name: "AssignmentTag",
                newName: "AssignmentTags");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentTag_TagId",
                table: "AssignmentTags",
                newName: "IX_AssignmentTags_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentTags",
                table: "AssignmentTags",
                columns: new[] { "AssignmentId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentTags_Assignment_AssignmentId",
                table: "AssignmentTags",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentTags_Tag_TagId",
                table: "AssignmentTags",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentTags_Assignment_AssignmentId",
                table: "AssignmentTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentTags_Tag_TagId",
                table: "AssignmentTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentTags",
                table: "AssignmentTags");

            migrationBuilder.RenameTable(
                name: "AssignmentTags",
                newName: "AssignmentTag");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentTags_TagId",
                table: "AssignmentTag",
                newName: "IX_AssignmentTag_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentTag",
                table: "AssignmentTag",
                columns: new[] { "AssignmentId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentTag_Assignment_AssignmentId",
                table: "AssignmentTag",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentTag_Tag_TagId",
                table: "AssignmentTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
