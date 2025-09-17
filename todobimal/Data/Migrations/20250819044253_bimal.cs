using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todobimal.Data.Migrations
{
    /// <inheritdoc />
    public partial class bimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasklist",
                table: "Tasklist");

            migrationBuilder.RenameTable(
                name: "Tasklist",
                newName: "Taskslist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taskslist",
                table: "Taskslist",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Taskslist",
                table: "Taskslist");

            migrationBuilder.RenameTable(
                name: "Taskslist",
                newName: "Tasklist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasklist",
                table: "Tasklist",
                column: "Id");
        }
    }
}
