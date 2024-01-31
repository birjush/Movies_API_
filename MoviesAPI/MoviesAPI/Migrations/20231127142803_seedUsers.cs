using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Key", "Email", "Password" },
                values: new object[,]
                {
                    { "User1", "user1@gmail.com", "user1" },
                    { "User2", "user2@gmail.com", "user2" },
                    { "User3", "user3@gmail.com", "user3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Key",
                keyValue: "User1");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Key",
                keyValue: "User2");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Key",
                keyValue: "User3");
        }
    }
}
