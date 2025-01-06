using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumirApiExterna.Migrations
{
    /// <inheritdoc />
    public partial class AddStreet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Street_StreetIdStreet",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Street",
                table: "Street");

            migrationBuilder.RenameTable(
                name: "Street",
                newName: "Streets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Streets",
                table: "Streets",
                column: "IdStreet");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Streets_StreetIdStreet",
                table: "Locations",
                column: "StreetIdStreet",
                principalTable: "Streets",
                principalColumn: "IdStreet",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Streets_StreetIdStreet",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Streets",
                table: "Streets");

            migrationBuilder.RenameTable(
                name: "Streets",
                newName: "Street");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Street",
                table: "Street",
                column: "IdStreet");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Street_StreetIdStreet",
                table: "Locations",
                column: "StreetIdStreet",
                principalTable: "Street",
                principalColumn: "IdStreet",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
