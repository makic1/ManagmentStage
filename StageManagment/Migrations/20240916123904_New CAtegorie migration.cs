using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StageManagment.Migrations
{
    /// <inheritdoc />
    public partial class NewCAtegoriemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$QRZUo4WXogavhwhfTbXA2O5Xjsa0LE1VaPYptod2RuBPjhn/xP/p.");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CustomerCategorie",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$mIMtXDRKnGY.gcJyRfWyNemFxLBhBa3/wuHOiWljqm2Xo8GKPxWZm");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CustomerCategorie",
                value: 0);
        }
    }
}
