using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureStageApp.Migrations
{
    public partial class facilityspellcorrection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaclilityDesc",
                table: "SchoolFacilityTbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaclilityDesc",
                table: "SchoolFacilityTbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
