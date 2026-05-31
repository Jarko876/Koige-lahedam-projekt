using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v310526EventMuudatused : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeatCategoryId",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatorId",
                table: "Events",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SeatCategoryId",
                table: "Events",
                column: "SeatCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Creators_CreatorId",
                table: "Events",
                column: "CreatorId",
                principalTable: "Creators",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_SeatCategories_SeatCategoryId",
                table: "Events",
                column: "SeatCategoryId",
                principalTable: "SeatCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Creators_CreatorId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_SeatCategories_SeatCategoryId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CreatorId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SeatCategoryId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SeatCategoryId",
                table: "Events");
        }
    }
}
