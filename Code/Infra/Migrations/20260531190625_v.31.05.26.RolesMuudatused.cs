using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v310526RolesMuudatused : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_RoleId",
                table: "Persons",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Roles_RoleId",
                table: "Persons",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Roles_RoleId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_RoleId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Persons");
        }
    }
}
