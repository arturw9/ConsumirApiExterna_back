using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationIdsUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinates_Locations_IdCoordinates",
                table: "Coordinates");

            migrationBuilder.DropForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdDateOfBirth",
                table: "DateOfBirths");

            migrationBuilder.DropForeignKey(
                name: "FK_Ids_Usuarios_Idid",
                table: "Ids");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Usuarios_IdLocation",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_IdLogin",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Names_Usuarios_IdName",
                table: "Names");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Usuarios_IdPicture",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Usuarios_IdRegistered",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Timezone_Locations_IdTimezone",
                table: "Timezone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone");

            migrationBuilder.RenameTable(
                name: "Timezone",
                newName: "Timezones");

            migrationBuilder.AddColumn<Guid>(
                name: "DobIdDateOfBirth",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Idid",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LocationIdLocation",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LoginIdLogin",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "NameIdName",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PictureIdPicture",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegisteredIdRegistered",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Street",
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
                name: "IdUsuario",
                table: "Registrations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Pictures",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Names",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Logins",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Ids",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "DateOfBirths",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Coordinates",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "Coordinates",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Timezones",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioIdUsuario",
                table: "Timezones",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timezones",
                table: "Timezones",
                column: "IdTimezone");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DobIdDateOfBirth",
                table: "Usuarios",
                column: "DobIdDateOfBirth");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Idid",
                table: "Usuarios",
                column: "Idid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LocationIdLocation",
                table: "Usuarios",
                column: "LocationIdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LoginIdLogin",
                table: "Usuarios",
                column: "LoginIdLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NameIdName",
                table: "Usuarios",
                column: "NameIdName");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PictureIdPicture",
                table: "Usuarios",
                column: "PictureIdPicture");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RegisteredIdRegistered",
                table: "Usuarios",
                column: "RegisteredIdRegistered");

            migrationBuilder.CreateIndex(
                name: "IX_Street_UsuarioIdUsuario",
                table: "Street",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdUsuario",
                table: "Registrations",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_IdUsuario",
                table: "Pictures",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Names_IdUsuario",
                table: "Names",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_IdUsuario",
                table: "Logins",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ids_IdUsuario",
                table: "Ids",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DateOfBirths_IdUsuario",
                table: "DateOfBirths",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_UsuarioIdUsuario",
                table: "Coordinates",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Timezones_UsuarioIdUsuario",
                table: "Timezones",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_DateOfBirths_DobIdDateOfBirth",
                table: "Usuarios",
                column: "DobIdDateOfBirth",
                principalTable: "DateOfBirths",
                principalColumn: "IdDateOfBirth",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Ids_Idid",
                table: "Usuarios",
                column: "Idid",
                principalTable: "Ids",
                principalColumn: "Idid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Locations_LocationIdLocation",
                table: "Usuarios",
                column: "LocationIdLocation",
                principalTable: "Locations",
                principalColumn: "IdLocation",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Logins_LoginIdLogin",
                table: "Usuarios",
                column: "LoginIdLogin",
                principalTable: "Logins",
                principalColumn: "IdLogin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Names_NameIdName",
                table: "Usuarios",
                column: "NameIdName",
                principalTable: "Names",
                principalColumn: "IdName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pictures_PictureIdPicture",
                table: "Usuarios",
                column: "PictureIdPicture",
                principalTable: "Pictures",
                principalColumn: "IdPicture",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Registrations_RegisteredIdRegistered",
                table: "Usuarios",
                column: "RegisteredIdRegistered",
                principalTable: "Registrations",
                principalColumn: "IdRegistered",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_DateOfBirths_DobIdDateOfBirth",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Ids_Idid",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Locations_LocationIdLocation",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Logins_LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Names_NameIdName",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pictures_PictureIdPicture",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Registrations_RegisteredIdRegistered",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_DobIdDateOfBirth",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Idid",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_LocationIdLocation",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_NameIdName",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PictureIdPicture",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RegisteredIdRegistered",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Street_UsuarioIdUsuario",
                table: "Street");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdUsuario",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_IdUsuario",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Names_IdUsuario",
                table: "Names");

            migrationBuilder.DropIndex(
                name: "IX_Logins_IdUsuario",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Locations_IdUsuario",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Ids_IdUsuario",
                table: "Ids");

            migrationBuilder.DropIndex(
                name: "IX_DateOfBirths_IdUsuario",
                table: "DateOfBirths");

            migrationBuilder.DropIndex(
                name: "IX_Coordinates_UsuarioIdUsuario",
                table: "Coordinates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timezones",
                table: "Timezones");

            migrationBuilder.DropIndex(
                name: "IX_Timezones_UsuarioIdUsuario",
                table: "Timezones");

            migrationBuilder.DropColumn(
                name: "DobIdDateOfBirth",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Idid",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "LocationIdLocation",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NameIdName",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PictureIdPicture",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RegisteredIdRegistered",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Street");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Street");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Names");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Ids");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "DateOfBirths");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Coordinates");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Coordinates");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Timezones");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Timezones");

            migrationBuilder.RenameTable(
                name: "Timezones",
                newName: "Timezone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timezone",
                table: "Timezone",
                column: "IdTimezone");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinates_Locations_IdCoordinates",
                table: "Coordinates",
                column: "IdCoordinates",
                principalTable: "Locations",
                principalColumn: "IdLocation",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DateOfBirths_Usuarios_IdDateOfBirth",
                table: "DateOfBirths",
                column: "IdDateOfBirth",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ids_Usuarios_Idid",
                table: "Ids",
                column: "Idid",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Usuarios_IdLocation",
                table: "Locations",
                column: "IdLocation",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_IdLogin",
                table: "Logins",
                column: "IdLogin",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Names_Usuarios_IdName",
                table: "Names",
                column: "IdName",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Usuarios_IdPicture",
                table: "Pictures",
                column: "IdPicture",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Usuarios_IdRegistered",
                table: "Registrations",
                column: "IdRegistered",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timezone_Locations_IdTimezone",
                table: "Timezone",
                column: "IdTimezone",
                principalTable: "Locations",
                principalColumn: "IdLocation",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
