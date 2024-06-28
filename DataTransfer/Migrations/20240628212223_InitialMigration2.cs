using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransfer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "1",
                column: "FlagImage",
                value: "Canada.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "2",
                column: "FlagImage",
                value: "Sweden.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "1",
                column: "FlagImage",
                value: "flags/Canada.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "2",
                column: "FlagImage",
                value: "flags/Sweden.png");
        }
    }
}
