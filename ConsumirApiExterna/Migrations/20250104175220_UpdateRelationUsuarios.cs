using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Coordinates_CoordinatesIdCoordinates",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Street_StreetIdStreet",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Timezone_TimezoneIdTimezone",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_DateOfBirth_DobIdDateOfBirth",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Id_Idid",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Location_LocationIdLocation",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Login_LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Name_NameIdName",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Picture_PictureIdPicture",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Registered_RegisteredIdRegistered",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registered",
                table: "Registered");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Name",
                table: "Name");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_CoordinatesIdCoordinates",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_TimezoneIdTimezone",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Id",
                table: "Id");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DateOfBirth",
                table: "DateOfBirth");

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
                name: "CoordinatesIdCoordinates",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "TimezoneIdTimezone",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Registered",
                newName: "Registrations");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "Name",
                newName: "Names");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "Logins");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Id",
                newName: "Ids");

            migrationBuilder.RenameTable(
                name: "DateOfBirth",
                newName: "DateOfBirths");

            migrationBuilder.RenameIndex(
                name: "IX_Location_StreetIdStreet",
                table: "Locations",
                newName: "IX_Locations_StreetIdStreet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations",
                column: "IdRegistered");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "IdPicture");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Names",
                table: "Names",
                column: "IdName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "IdLogin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "IdLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ids",
                table: "Ids",
                column: "Idid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateOfBirths",
                table: "DateOfBirths",
                column: "IdDateOfBirth");

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
                name: "FK_Locations_Street_StreetIdStreet",
                table: "Locations",
                column: "StreetIdStreet",
                principalTable: "Street",
                principalColumn: "IdStreet",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Locations_Street_StreetIdStreet",
                table: "Locations");

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
                name: "PK_Registrations",
                table: "Registrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Names",
                table: "Names");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ids",
                table: "Ids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DateOfBirths",
                table: "DateOfBirths");

            migrationBuilder.RenameTable(
                name: "Registrations",
                newName: "Registered");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameTable(
                name: "Names",
                newName: "Name");

            migrationBuilder.RenameTable(
                name: "Logins",
                newName: "Login");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Ids",
                newName: "Id");

            migrationBuilder.RenameTable(
                name: "DateOfBirths",
                newName: "DateOfBirth");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_StreetIdStreet",
                table: "Location",
                newName: "IX_Location_StreetIdStreet");

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
                name: "CoordinatesIdCoordinates",
                table: "Location",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TimezoneIdTimezone",
                table: "Location",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registered",
                table: "Registered",
                column: "IdRegistered");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "IdPicture");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Name",
                table: "Name",
                column: "IdName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "IdLogin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "IdLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Id",
                table: "Id",
                column: "Idid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateOfBirth",
                table: "DateOfBirth",
                column: "IdDateOfBirth");

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
                name: "IX_Location_CoordinatesIdCoordinates",
                table: "Location",
                column: "CoordinatesIdCoordinates");

            migrationBuilder.CreateIndex(
                name: "IX_Location_TimezoneIdTimezone",
                table: "Location",
                column: "TimezoneIdTimezone");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Coordinates_CoordinatesIdCoordinates",
                table: "Location",
                column: "CoordinatesIdCoordinates",
                principalTable: "Coordinates",
                principalColumn: "IdCoordinates",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Street_StreetIdStreet",
                table: "Location",
                column: "StreetIdStreet",
                principalTable: "Street",
                principalColumn: "IdStreet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Timezone_TimezoneIdTimezone",
                table: "Location",
                column: "TimezoneIdTimezone",
                principalTable: "Timezone",
                principalColumn: "IdTimezone",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_DateOfBirth_DobIdDateOfBirth",
                table: "Usuarios",
                column: "DobIdDateOfBirth",
                principalTable: "DateOfBirth",
                principalColumn: "IdDateOfBirth",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Id_Idid",
                table: "Usuarios",
                column: "Idid",
                principalTable: "Id",
                principalColumn: "Idid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Location_LocationIdLocation",
                table: "Usuarios",
                column: "LocationIdLocation",
                principalTable: "Location",
                principalColumn: "IdLocation",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Login_LoginIdLogin",
                table: "Usuarios",
                column: "LoginIdLogin",
                principalTable: "Login",
                principalColumn: "IdLogin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Name_NameIdName",
                table: "Usuarios",
                column: "NameIdName",
                principalTable: "Name",
                principalColumn: "IdName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Picture_PictureIdPicture",
                table: "Usuarios",
                column: "PictureIdPicture",
                principalTable: "Picture",
                principalColumn: "IdPicture",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Registered_RegisteredIdRegistered",
                table: "Usuarios",
                column: "RegisteredIdRegistered",
                principalTable: "Registered",
                principalColumn: "IdRegistered",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
