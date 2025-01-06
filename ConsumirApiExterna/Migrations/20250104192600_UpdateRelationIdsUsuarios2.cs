using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationIdsUsuarios2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinates_Usuarios_UsuarioIdUsuario",
                table: "Coordinates");

            migrationBuilder.DropForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdUsuario",
                table: "DateOfBirths");

            migrationBuilder.DropForeignKey(
                name: "FK_Ids_Usuarios_IdUsuario",
                table: "Ids");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Coordinates_IdUsuario",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Timezones_IdUsuario",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Usuarios_IdUsuario",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_IdUsuario",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Names_Usuarios_IdUsuario",
                table: "Names");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Usuarios_IdUsuario",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Usuarios_IdUsuario",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Street_Usuarios_UsuarioIdUsuario",
                table: "Street");

            migrationBuilder.DropForeignKey(
                name: "FK_Timezones_Usuarios_UsuarioIdUsuario",
                table: "Timezones");

            migrationBuilder.DropIndex(
                name: "IX_Timezones_UsuarioIdUsuario",
                table: "Timezones");

            migrationBuilder.DropIndex(
                name: "IX_Street_UsuarioIdUsuario",
                table: "Street");

            migrationBuilder.DropIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Coordinates_UsuarioIdUsuario",
                table: "Coordinates");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Timezones");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Street");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Coordinates");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdUsuario",
                table: "DateOfBirths",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Ids_Usuarios_IdUsuario",
                table: "Ids",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Coordinates_IdLocation",
                table: "Locations",
                column: "IdLocation",
                principalTable: "Coordinates",
                principalColumn: "IdCoordinates",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Timezones_IdLocation",
                table: "Locations",
                column: "IdLocation",
                principalTable: "Timezones",
                principalColumn: "IdTimezone",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Usuarios_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_IdUsuario",
                table: "Logins",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Names_Usuarios_IdUsuario",
                table: "Names",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Usuarios_IdUsuario",
                table: "Pictures",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Usuarios_IdUsuario",
                table: "Registrations",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdUsuario",
                table: "DateOfBirths");

            migrationBuilder.DropForeignKey(
                name: "FK_Ids_Usuarios_IdUsuario",
                table: "Ids");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Coordinates_IdLocation",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Timezones_IdLocation",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Usuarios_IdUsuario",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_IdUsuario",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Names_Usuarios_IdUsuario",
                table: "Names");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Usuarios_IdUsuario",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Usuarios_IdUsuario",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "Timezones",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "Street",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "Coordinates",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Timezones_UsuarioIdUsuario",
                table: "Timezones",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Street_UsuarioIdUsuario",
                table: "Street",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_UsuarioIdUsuario",
                table: "Coordinates",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinates_Usuarios_UsuarioIdUsuario",
                table: "Coordinates",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdUsuario",
                table: "DateOfBirths",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ids_Usuarios_IdUsuario",
                table: "Ids",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Coordinates_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                principalTable: "Coordinates",
                principalColumn: "IdCoordinates",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Timezones_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                principalTable: "Timezones",
                principalColumn: "IdTimezone",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Usuarios_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_IdUsuario",
                table: "Logins",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Names_Usuarios_IdUsuario",
                table: "Names",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Usuarios_IdUsuario",
                table: "Pictures",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Usuarios_IdUsuario",
                table: "Registrations",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Street_Usuarios_UsuarioIdUsuario",
                table: "Street",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timezones_Usuarios_UsuarioIdUsuario",
                table: "Timezones",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
