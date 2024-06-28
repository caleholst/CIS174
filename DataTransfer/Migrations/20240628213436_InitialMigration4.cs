using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransfer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Games_GameID",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "GameID",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "1",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "10",
                column: "GameID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "11",
                column: "GameID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "12",
                column: "GameID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "13",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "14",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "15",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "16",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "17",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "18",
                column: "GameID",
                value: "paralympics");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "19",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "2",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "20",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "21",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "22",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "23",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "24",
                column: "GameID",
                value: "youth");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "3",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "4",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "5",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "6",
                column: "GameID",
                value: "winter");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "7",
                column: "GameID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "8",
                column: "GameID",
                value: "summer");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "9",
                column: "GameID",
                value: "summer");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Games_GameID",
                table: "Countries",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "GameID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Games_GameID",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "GameID",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "1",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "10",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "11",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "12",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "13",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "14",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "15",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "16",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "17",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "18",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "19",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "2",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "20",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "21",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "22",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "23",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "24",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "3",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "4",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "5",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "6",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "7",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "8",
                column: "GameID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "9",
                column: "GameID",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Games_GameID",
                table: "Countries",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "GameID");
        }
    }
}
