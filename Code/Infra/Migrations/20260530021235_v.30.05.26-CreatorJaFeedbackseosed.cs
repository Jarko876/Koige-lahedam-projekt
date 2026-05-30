using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v300526CreatorJaFeedbackseosed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EventObjectID",
                table: "Feedbacks",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EventObjectId",
                table: "EventObjects",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventId1",
                table: "EventCreator",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_EventObjectID",
                table: "Feedbacks",
                column: "EventObjectID");

            migrationBuilder.CreateIndex(
                name: "IX_EventObjects_EventObjectId",
                table: "EventObjects",
                column: "EventObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_EventId1",
                table: "EventCreator",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Events_EventId1",
                table: "EventCreator",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventObjects_EventObjects_EventObjectId",
                table: "EventObjects",
                column: "EventObjectId",
                principalTable: "EventObjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectID",
                table: "Feedbacks",
                column: "EventObjectID",
                principalTable: "EventObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Events_EventId1",
                table: "EventCreator");

            migrationBuilder.DropForeignKey(
                name: "FK_EventObjects_EventObjects_EventObjectId",
                table: "EventObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectID",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_EventObjectID",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_EventObjects_EventObjectId",
                table: "EventObjects");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_EventId1",
                table: "EventCreator");

            migrationBuilder.DropColumn(
                name: "EventObjectID",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "EventObjectId",
                table: "EventObjects");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "EventCreator");
        }
    }
}
