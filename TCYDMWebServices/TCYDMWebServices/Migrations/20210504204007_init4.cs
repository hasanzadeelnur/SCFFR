using Microsoft.EntityFrameworkCore.Migrations;

namespace TCYDMWebServices.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regions_countries_CountryId",
                table: "regions");

            migrationBuilder.DropIndex(
                name: "IX_regions_CountryId",
                table: "regions");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "regions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "regions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_regions_CountryId",
                table: "regions",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_regions_countries_CountryId",
                table: "regions",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
