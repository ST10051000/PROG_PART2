using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriEnergyConnectPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Farmer",
                newName: "FarmerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FarmerId",
                table: "Farmer",
                newName: "Id");
        }
    }
}
