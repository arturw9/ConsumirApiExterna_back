using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class AddStreet3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "DobIdDateOfBirth",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Idid",
                table: "Usuarios",
                newName: "IdId");

            migrationBuilder.RenameColumn(
                name: "RegisteredIdRegistered",
                table: "Usuarios",
                newName: "IdRegistered");

            migrationBuilder.RenameColumn(
                name: "PictureIdPicture",
                table: "Usuarios",
                newName: "IdPicture");

            migrationBuilder.RenameColumn(
                name: "NameIdName",
                table: "Usuarios",
                newName: "IdName");

            migrationBuilder.RenameColumn(
                name: "LoginIdLogin",
                table: "Usuarios",
                newName: "IdLogin");

            migrationBuilder.RenameColumn(
                name: "LocationIdLocation",
                table: "Usuarios",
                newName: "IdLocation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdId",
                table: "Usuarios",
                newName: "Idid");

            migrationBuilder.RenameColumn(
                name: "IdRegistered",
                table: "Usuarios",
                newName: "RegisteredIdRegistered");

            migrationBuilder.RenameColumn(
                name: "IdPicture",
                table: "Usuarios",
                newName: "PictureIdPicture");

            migrationBuilder.RenameColumn(
                name: "IdName",
                table: "Usuarios",
                newName: "NameIdName");

            migrationBuilder.RenameColumn(
                name: "IdLogin",
                table: "Usuarios",
                newName: "LoginIdLogin");

            migrationBuilder.RenameColumn(
                name: "IdLocation",
                table: "Usuarios",
                newName: "LocationIdLocation");

            migrationBuilder.AddColumn<Guid>(
                name: "DobIdDateOfBirth",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
