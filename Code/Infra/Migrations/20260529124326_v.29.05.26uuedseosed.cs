using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v290526uuedseosed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seats_HallId",
                table: "Seats");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallId_Row_Number",
                table: "Seats",
                columns: new[] { "HallId", "Row", "Number" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seats_HallId_Row_Number",
                table: "Seats");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallId",
                table: "Seats",
                column: "HallId");
        }
    }
}
