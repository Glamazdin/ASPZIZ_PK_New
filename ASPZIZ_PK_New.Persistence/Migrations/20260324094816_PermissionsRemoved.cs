using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPZIZ_PK_New.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PermissionsRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permission_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permission_User",
                columns: table => new
                {
                    permUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    partId = table.Column<byte>(type: "tinyint", nullable: false),
                    permissionId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission_User", x => x.permUserId);
                    table.ForeignKey(
                        name: "FK_PermissionUser_AspNetUsers",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permission_User_userId",
                table: "Permission_User",
                column: "userId");
        }
    }
}
