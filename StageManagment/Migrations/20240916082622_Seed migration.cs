using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StageManagment.Migrations
{
    /// <inheritdoc />
    public partial class Seedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Tickets",
                newName: "CustomerCountry");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "ProgramStages",
                newName: "DurationInMinutes");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "HashPassword", "Username" },
                values: new object[] { 1, "$2a$11$mIMtXDRKnGY.gcJyRfWyNemFxLBhBa3/wuHOiWljqm2Xo8GKPxWZm", "admin" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistCategorie", "Name" },
                values: new object[] { 1, 1, "Bushido" });

            migrationBuilder.InsertData(
                table: "ProgramStages",
                columns: new[] { "ProgramStageId", "ArtistId", "DurationInMinutes", "EndPriceInEuro", "IsPayd", "Name", "PriceInEuro", "StartPriceInEuro" },
                values: new object[] { 1, 1, 150L, 100m, true, "Junge berliner", 100m, 0m });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "PerformanceId", "EndPerformance", "IsActive", "Name", "ProgramStageId", "StartPerformance" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), true, "Teil1", 1, new DateTime(2024, 9, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CustomerAddress", "CustomerCategorie", "CustomerCountry", "CustomerFirstname", "CustomerLastname", "CustomerPLZ", "PaydPriceInEuro", "PerformanceId", "PriceInEuro", "SeatNumber", "SeatRow" },
                values: new object[] { 1, "Hohenesmeserstarsse 12", 0, "Hohenems", "Mert", "Can", 8454, 50m, 1, 50m, 1, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "PerformanceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgramStages",
                keyColumn: "ProgramStageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "CustomerCountry",
                table: "Tickets",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "DurationInMinutes",
                table: "ProgramStages",
                newName: "Duration");
        }
    }
}
