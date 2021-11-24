using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Migrations.UserDb
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "lassorocks@gmail.com", "Bob", "Lasso", "Password" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 2, "sarahforprez@outlook.com", "Sarah", "Chapman", "$chap4potus" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 3, "late4class@hotmail.com", "Kevin", "Roger", "incorrect" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 4, "etsuadmin@etsu.edu", "ETSUadmin", "ETSUadmin", "root" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
