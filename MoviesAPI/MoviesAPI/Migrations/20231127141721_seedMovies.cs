using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "ID", "Country", "Director", "Genre", "Industry", "Name", "Synopsis" },
                values: new object[,]
                {
                    { 1, "India", "Unknown", "Patriotic", "Unknown", "Chanakya", "Lorem Ipsum" },
                    { 2, "India", "Unknown", "Patriotic", "Unknown", "Chanakya", "Lorem Ipsum" },
                    { 3, "India", "Unknown", "Patriotic", "Unknown", "Chanakya", "Lorem Ipsum" },
                    { 4, "India", "Unknown", "Patriotic", "Unknown", "Chanakya", "Lorem Ipsum" },
                    { 5, "India", "Unknown", "Patriotic", "Unknown", "Chanakya", "Lorem Ipsum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
