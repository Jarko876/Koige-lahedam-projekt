using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class addPaymentsToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CartId1",
                table: "Payments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CartId1",
                table: "Payments",
                column: "CartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Carts_CartId1",
                table: "Payments",
                column: "CartId1",
                principalTable: "Carts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Carts_CartId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CartId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "Payments");
        }
    }
}
