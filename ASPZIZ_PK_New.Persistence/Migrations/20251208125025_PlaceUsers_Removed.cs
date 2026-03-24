using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPZIZ_PK_New.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PlaceUsers_Removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Place_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Place_User",
                columns: table => new
                {
                    userPlaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placeId = table.Column<byte>(type: "tinyint", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place_User", x => x.userPlaceId);
                    table.ForeignKey(
                        name: "FK_PlaceUser_AspNetUsers",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Place_User_Place_User",
                        column: x => x.placeId,
                        principalTable: "Place",
                        principalColumn: "placeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Place_User_placeId",
                table: "Place_User",
                column: "placeId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_User_userId",
                table: "Place_User",
                column: "userId");
        }
    }
}
