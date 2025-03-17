using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Server.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prodBrand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "prodCategory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "prodColor",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "prodMaterial",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "prodName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "prodPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "prodSize",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prodBrand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodColor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodMaterial",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prodSize",
                table: "Products");
        }
    }
}
