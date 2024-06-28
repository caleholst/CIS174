using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransfer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "10",
                column: "FlagImage",
                value: "Brazil.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "11",
                column: "FlagImage",
                value: "Netherlands.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "12",
                column: "FlagImage",
                value: "US.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "13",
                column: "FlagImage",
                value: "Thailand.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "14",
                column: "FlagImage",
                value: "Uruguay.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "15",
                column: "FlagImage",
                value: "Ukraine.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "16",
                column: "FlagImage",
                value: "Austria.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "17",
                column: "FlagImage",
                value: "Pakistan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "18",
                column: "FlagImage",
                value: "Zimbabwe.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "19",
                column: "FlagImage",
                value: "France.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "20",
                column: "FlagImage",
                value: "Cyprus.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "21",
                column: "FlagImage",
                value: "Russia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "22",
                column: "FlagImage",
                value: "Finland.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "23",
                column: "FlagImage",
                value: "Slovakia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "24",
                column: "FlagImage",
                value: "Portugal.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "3",
                column: "FlagImage",
                value: "UK.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "4",
                column: "FlagImage",
                value: "Jamaica.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "5",
                column: "FlagImage",
                value: "Italy.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "6",
                column: "FlagImage",
                value: "Japan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "7",
                column: "FlagImage",
                value: "Germany.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "8",
                column: "FlagImage",
                value: "China.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "9",
                column: "FlagImage",
                value: "Mexico.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "10",
                column: "FlagImage",
                value: "flags/Brazil.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "11",
                column: "FlagImage",
                value: "flags/Netherlands.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "12",
                column: "FlagImage",
                value: "flags/US.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "13",
                column: "FlagImage",
                value: "flags/Thailand.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "14",
                column: "FlagImage",
                value: "flags/Uruguay.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "15",
                column: "FlagImage",
                value: "flags/Ukraine.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "16",
                column: "FlagImage",
                value: "flags/Austria.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "17",
                column: "FlagImage",
                value: "flags/Pakistan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "18",
                column: "FlagImage",
                value: "flags/Zimbabwe.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "19",
                column: "FlagImage",
                value: "flags/France.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "20",
                column: "FlagImage",
                value: "flags/Cyprus.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "21",
                column: "FlagImage",
                value: "flags/Russia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "22",
                column: "FlagImage",
                value: "flags/Finland.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "23",
                column: "FlagImage",
                value: "flags/Slovakia.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "24",
                column: "FlagImage",
                value: "flags/Portugal.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "3",
                column: "FlagImage",
                value: "flags/UK.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "4",
                column: "FlagImage",
                value: "flags/Jamaica.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "5",
                column: "FlagImage",
                value: "flags/Italy.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "6",
                column: "FlagImage",
                value: "flags/Japan.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "7",
                column: "FlagImage",
                value: "flags/Germany.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "8",
                column: "FlagImage",
                value: "flags/China.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "9",
                column: "FlagImage",
                value: "flags/Mexico.png");
        }
    }
}
