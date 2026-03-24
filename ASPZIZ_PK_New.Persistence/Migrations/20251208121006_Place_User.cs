using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPZIZ_PK_New.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Place_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPlace");
        }
    }
}
