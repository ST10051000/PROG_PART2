using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriEnergyConnectPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Farmer_Id",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "FarmerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FarmerId",
                table: "Product",
                column: "FarmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product",
                column: "FarmerId",
                principalTable: "Farmer",
                principalColumn: "FarmerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_FarmerId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "FarmerId",
                table: "Product",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Farmer_Id",
                table: "Product",
                column: "Id",
                principalTable: "Farmer",
                principalColumn: "FarmerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
