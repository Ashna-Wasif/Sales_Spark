using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    prodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodPrice = table.Column<int>(type: "int", nullable: false),
                    prodMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodBrand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.prodId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_AccessLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    actionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    actionDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_UserLog_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserLog_UserId",
                table: "UserLog",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
