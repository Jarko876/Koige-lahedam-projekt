using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Infra.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEnumsToStrings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventObjects_Events_EventId",
                table: "EventObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_EventObjects_Halls_HallId",
                table: "EventObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_EventObjects_EventObjectId",
                table: "Genres");

            migrationBuilder.DropTable(
                name: "EventObjectGenres");

            migrationBuilder.RenameColumn(
                name: "EventObjectId",
                table: "Genres",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_EventObjectId",
                table: "Genres",
                newName: "IX_Genres_EventId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Genres",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "EventObjects",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "EventObjects",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "HallId",
                table: "EventObjects",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "EventId",
                table: "EventObjects",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "EventGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EventId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GenreId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Details = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventGenres_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventGenres_EventId",
                table: "EventGenres",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGenres_GenreId",
                table: "EventGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventObjects_Events_EventId",
                table: "EventObjects",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventObjects_Halls_HallId",
                table: "EventObjects",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Events_EventId",
                table: "Genres",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventObjects_Events_EventId",
                table: "EventObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_EventObjects_Halls_HallId",
                table: "EventObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Events_EventId",
                table: "Genres");

            migrationBuilder.DropTable(
                name: "EventGenres");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Genres",
                newName: "EventObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_EventId",
                table: "Genres",
                newName: "IX_Genres_EventObjectId");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Genres",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "EventObjects",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "EventObjects",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "HallId",
                table: "EventObjects",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EventId",
                table: "EventObjects",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EventObjectGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EventObjectId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GenreId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Details = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventObjectGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventObjectGenres_EventObjects_EventObjectId",
                        column: x => x.EventObjectId,
                        principalTable: "EventObjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventObjectGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventObjectGenres_EventObjectId",
                table: "EventObjectGenres",
                column: "EventObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EventObjectGenres_GenreId",
                table: "EventObjectGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventObjects_Events_EventId",
                table: "EventObjects",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventObjects_Halls_HallId",
                table: "EventObjects",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_EventObjects_EventObjectId",
                table: "Genres",
                column: "EventObjectId",
                principalTable: "EventObjects",
                principalColumn: "Id");
        }
    }
}
