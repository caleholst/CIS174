using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataTransfer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameID", "Name" },
                values: new object[,]
                {
                    { "1", "indoor", "flags/Canada.png", null, "Canada" },
                    { "10", "outdoor", "flags/Brazil.png", null, "Brazil" },
                    { "11", "outdoor", "flags/Netherlands.png", null, "Netherlands" },
                    { "12", "outdoor", "flags/US.png", null, "USA" },
                    { "13", "indoor", "flags/Thailand.png", null, "Thailand" },
                    { "14", "indoor", "flags/Uruguay.png", null, "Uruguay" },
                    { "15", "indoor", "flags/Ukraine.png", null, "Ukraine" },
                    { "16", "outdoor", "flags/Austria.png", null, "Austria" },
                    { "17", "outdoor", "flags/Pakistan.png", null, "Pakistan" },
                    { "18", "outdoor", "flags/Zimbabwe.png", null, "Zimbabwe" },
                    { "19", "indoor", "flags/France.png", null, "France" },
                    { "2", "indoor", "flags/Sweden.png", null, "Sweden" },
                    { "20", "indoor", "flags/Cyprus.png", null, "Cyprus" },
                    { "21", "indoor", "flags/Russia.png", null, "Russia" },
                    { "22", "outdoor", "flags/Finland.png", null, "Finland" },
                    { "23", "outdoor", "flags/Slovakia.png", null, "Slovakia" },
                    { "24", "outdoor", "flags/Portugal.png", null, "Portugal" },
                    { "3", "indoor", "flags/UK.png", null, "Great Britain" },
                    { "4", "outdoor", "flags/Jamaica.png", null, "Jamaica" },
                    { "5", "outdoor", "flags/Italy.png", null, "Italy" },
                    { "6", "outdoor", "flags/Japan.png", null, "Japan" },
                    { "7", "indoor", "flags/Germany.png", null, "Germany" },
                    { "8", "indoor", "flags/China.png", null, "China" },
                    { "9", "indoor", "flags/Mexico.png", null, "Mexico" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "9");
        }
    }
}
