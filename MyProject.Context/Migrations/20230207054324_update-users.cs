using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class updateusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Childrens_Users_ParentId",
                table: "Childrens");

            migrationBuilder.DropColumn(
                name: "IdParent",
                table: "Childrens");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Childrens",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Childrens_ParentId",
                table: "Childrens",
                newName: "IX_Childrens_IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Childrens_Users_IdUser",
                table: "Childrens",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Childrens_Users_IdUser",
                table: "Childrens");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Childrens",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Childrens_IdUser",
                table: "Childrens",
                newName: "IX_Childrens_ParentId");

            migrationBuilder.AddColumn<int>(
                name: "IdParent",
                table: "Childrens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Childrens_Users_ParentId",
                table: "Childrens",
                column: "ParentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
