using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P04_RelationDB.Migrations
{
    /// <inheritdoc />
    public partial class ProductExtend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductExtend_Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ProductExtend_Weight",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductExtend_Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductExtend_Weight",
                table: "Products");
        }
    }
}
