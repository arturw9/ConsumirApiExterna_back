using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Coordinates_IdLocation",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Streets_StreetIdStreet",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Timezones_IdLocation",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_StreetIdStreet",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StreetIdStreet",
                table: "Locations",
                newName: "IdTimezone");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCoordinates",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdStreet",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCoordinates",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IdStreet",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdTimezone",
                table: "Locations",
                newName: "StreetIdStreet");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StreetIdStreet",
                table: "Locations",
                column: "StreetIdStreet");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Coordinates_IdLocation",
                table: "Locations",
                column: "IdLocation",
                principalTable: "Coordinates",
                principalColumn: "IdCoordinates",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Streets_StreetIdStreet",
                table: "Locations",
                column: "StreetIdStreet",
                principalTable: "Streets",
                principalColumn: "IdStreet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Timezones_IdLocation",
                table: "Locations",
                column: "IdLocation",
                principalTable: "Timezones",
                principalColumn: "IdTimezone",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
