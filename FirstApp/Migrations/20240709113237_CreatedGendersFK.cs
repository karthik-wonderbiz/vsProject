using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedGendersFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Customers");
        }
    }
}
