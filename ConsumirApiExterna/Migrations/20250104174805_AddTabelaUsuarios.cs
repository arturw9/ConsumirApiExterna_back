using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    IdCoordinates = table.Column<Guid>(type: "uuid", nullable: false),
                    Latitude = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.IdCoordinates);
                });

            migrationBuilder.CreateTable(
                name: "DateOfBirth",
                columns: table => new
                {
                    IdDateOfBirth = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateOfBirth", x => x.IdDateOfBirth);
                });

            migrationBuilder.CreateTable(
                name: "Id",
                columns: table => new
                {
                    Idid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Id", x => x.Idid);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    IdLogin = table.Column<Guid>(type: "uuid", nullable: false),
                    Uuid = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    Md5 = table.Column<string>(type: "text", nullable: false),
                    Sha1 = table.Column<string>(type: "text", nullable: false),
                    Sha256 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    IdName = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    First = table.Column<string>(type: "text", nullable: false),
                    Last = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.IdName);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    IdPicture = table.Column<Guid>(type: "uuid", nullable: false),
                    Large = table.Column<string>(type: "text", nullable: false),
                    Medium = table.Column<string>(type: "text", nullable: false),
                    Thumbnail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.IdPicture);
                });

            migrationBuilder.CreateTable(
                name: "Registered",
                columns: table => new
                {
                    IdRegistered = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registered", x => x.IdRegistered);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    IdStreet = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.IdStreet);
                });

            migrationBuilder.CreateTable(
                name: "Timezone",
                columns: table => new
                {
                    IdTimezone = table.Column<Guid>(type: "uuid", nullable: false),
                    Offset = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timezone", x => x.IdTimezone);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    IdLocation = table.Column<Guid>(type: "uuid", nullable: false),
                    StreetIdStreet = table.Column<Guid>(type: "uuid", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Postcode = table.Column<string>(type: "text", nullable: false),
                    CoordinatesIdCoordinates = table.Column<Guid>(type: "uuid", nullable: false),
                    TimezoneIdTimezone = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.IdLocation);
                    table.ForeignKey(
                        name: "FK_Location_Coordinates_CoordinatesIdCoordinates",
                        column: x => x.CoordinatesIdCoordinates,
                        principalTable: "Coordinates",
                        principalColumn: "IdCoordinates",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Street_StreetIdStreet",
                        column: x => x.StreetIdStreet,
                        principalTable: "Street",
                        principalColumn: "IdStreet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Timezone_TimezoneIdTimezone",
                        column: x => x.TimezoneIdTimezone,
                        principalTable: "Timezone",
                        principalColumn: "IdTimezone",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    NameIdName = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationIdLocation = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    LoginIdLogin = table.Column<Guid>(type: "uuid", nullable: false),
                    DobIdDateOfBirth = table.Column<Guid>(type: "uuid", nullable: false),
                    RegisteredIdRegistered = table.Column<Guid>(type: "uuid", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Cell = table.Column<string>(type: "text", nullable: false),
                    Idid = table.Column<Guid>(type: "uuid", nullable: false),
                    PictureIdPicture = table.Column<Guid>(type: "uuid", nullable: false),
                    Nat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_DateOfBirth_DobIdDateOfBirth",
                        column: x => x.DobIdDateOfBirth,
                        principalTable: "DateOfBirth",
                        principalColumn: "IdDateOfBirth",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Id_Idid",
                        column: x => x.Idid,
                        principalTable: "Id",
                        principalColumn: "Idid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Location_LocationIdLocation",
                        column: x => x.LocationIdLocation,
                        principalTable: "Location",
                        principalColumn: "IdLocation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Login_LoginIdLogin",
                        column: x => x.LoginIdLogin,
                        principalTable: "Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Name_NameIdName",
                        column: x => x.NameIdName,
                        principalTable: "Name",
                        principalColumn: "IdName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Picture_PictureIdPicture",
                        column: x => x.PictureIdPicture,
                        principalTable: "Picture",
                        principalColumn: "IdPicture",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Registered_RegisteredIdRegistered",
                        column: x => x.RegisteredIdRegistered,
                        principalTable: "Registered",
                        principalColumn: "IdRegistered",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_CoordinatesIdCoordinates",
                table: "Location",
                column: "CoordinatesIdCoordinates");

            migrationBuilder.CreateIndex(
                name: "IX_Location_StreetIdStreet",
                table: "Location",
                column: "StreetIdStreet");

            migrationBuilder.CreateIndex(
                name: "IX_Location_TimezoneIdTimezone",
                table: "Location",
                column: "TimezoneIdTimezone");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "DateOfBirth");

            migrationBuilder.DropTable(
                name: "Id");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "Registered");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "Street");

            migrationBuilder.DropTable(
                name: "Timezone");
        }
    }
}
