using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v210526_AllaniCRUDid2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_HallCategories_HallCategoryId1",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_HallCategoryId1",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "HallCategoryId1",
                table: "Halls");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HallCategoryId1",
                table: "Halls",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_HallCategoryId1",
                table: "Halls",
                column: "HallCategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_HallCategories_HallCategoryId1",
                table: "Halls",
                column: "HallCategoryId1",
                principalTable: "HallCategories",
                principalColumn: "Id");
        }
    }
}
