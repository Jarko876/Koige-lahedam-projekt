using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v210526_AllaniCRUDid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tickets",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tickets");
        }
    }
}
