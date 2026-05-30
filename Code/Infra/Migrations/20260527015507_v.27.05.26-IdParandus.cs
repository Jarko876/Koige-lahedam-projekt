using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v270526IdParandus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Creators_CreatorId",
                table: "EventCreator");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_CreatorId",
                table: "EventCreator");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Feedbacks",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId1",
                table: "EventCreator",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Creators",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_CreatorId1",
                table: "EventCreator",
                column: "CreatorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Creators_CreatorId1",
                table: "EventCreator",
                column: "CreatorId1",
                principalTable: "Creators",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Creators_CreatorId1",
                table: "EventCreator");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_CreatorId1",
                table: "EventCreator");

            migrationBuilder.DropColumn(
                name: "CreatorId1",
                table: "EventCreator");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Creators",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_CreatorId",
                table: "EventCreator",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Creators_CreatorId",
                table: "EventCreator",
                column: "CreatorId",
                principalTable: "Creators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
