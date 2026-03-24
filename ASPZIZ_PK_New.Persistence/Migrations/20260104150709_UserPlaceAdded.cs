using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPZIZ_PK_New.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserPlaceAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPlace");

            migrationBuilder.AddColumn<byte>(
                name: "PlaceId",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PlaceId",
                table: "AspNetUsers",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Place_PlaceId",
                table: "AspNetUsers",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "placeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Place_PlaceId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PlaceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ApplicationUserPlace",
                columns: table => new
                {
                    PlacesPlaceId = table.Column<byte>(type: "tinyint", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPlace", x => new { x.PlacesPlaceId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPlace_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPlace_Place_PlacesPlaceId",
                        column: x => x.PlacesPlaceId,
                        principalTable: "Place",
                        principalColumn: "placeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPlace_UsersId",
                table: "ApplicationUserPlace",
                column: "UsersId");
        }
    }
}
