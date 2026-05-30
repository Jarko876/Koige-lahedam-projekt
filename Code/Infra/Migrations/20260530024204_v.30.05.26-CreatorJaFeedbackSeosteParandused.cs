using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v300526CreatorJaFeedbackSeosteParandused : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Creators_CreatorId1",
                table: "EventCreator");

            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Events_EventId1",
                table: "EventCreator");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectID",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_CreatorId1",
                table: "EventCreator");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_EventId1",
                table: "EventCreator");

            migrationBuilder.DropColumn(
                name: "CreatorId1",
                table: "EventCreator");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "EventCreator");

            migrationBuilder.RenameColumn(
                name: "EventObjectID",
                table: "Feedbacks",
                newName: "EventObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_EventObjectID",
                table: "Feedbacks",
                newName: "IX_Feedbacks_EventObjectId");

            migrationBuilder.AlterColumn<Guid>(
                name: "EventObjectId",
                table: "Feedbacks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Feedbacks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Feedbacks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EventId",
                table: "EventCreator",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatorId",
                table: "EventCreator",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EventCreator",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Creators",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Creators",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_CreatorId",
                table: "EventCreator",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_EventId",
                table: "EventCreator",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Creators_CreatorId",
                table: "EventCreator",
                column: "CreatorId",
                principalTable: "Creators",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Events_EventId",
                table: "EventCreator",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectId",
                table: "Feedbacks",
                column: "EventObjectId",
                principalTable: "EventObjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Creators_CreatorId",
                table: "EventCreator");

            migrationBuilder.DropForeignKey(
                name: "FK_EventCreator_Events_EventId",
                table: "EventCreator");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_CreatorId",
                table: "EventCreator");

            migrationBuilder.DropIndex(
                name: "IX_EventCreator_EventId",
                table: "EventCreator");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Creators");

            migrationBuilder.RenameColumn(
                name: "EventObjectId",
                table: "Feedbacks",
                newName: "EventObjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_EventObjectId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_EventObjectID");

            migrationBuilder.AlterColumn<Guid>(
                name: "EventObjectID",
                table: "Feedbacks",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "EventCreator",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatorId",
                table: "EventCreator",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EventCreator",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId1",
                table: "EventCreator",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventId1",
                table: "EventCreator",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_CreatorId1",
                table: "EventCreator",
                column: "CreatorId1");

            migrationBuilder.CreateIndex(
                name: "IX_EventCreator_EventId1",
                table: "EventCreator",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Creators_CreatorId1",
                table: "EventCreator",
                column: "CreatorId1",
                principalTable: "Creators",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCreator_Events_EventId1",
                table: "EventCreator",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_EventObjects_EventObjectID",
                table: "Feedbacks",
                column: "EventObjectID",
                principalTable: "EventObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
