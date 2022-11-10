using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureStageApp.Migrations
{
    public partial class facilityspellcorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolFacilityTbl_FacilityTbl_FaclilityID",
                table: "SchoolFacilityTbl");

            migrationBuilder.RenameColumn(
                name: "FaclilityID",
                table: "SchoolFacilityTbl",
                newName: "FacilityID");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolFacilityTbl_FaclilityID",
                table: "SchoolFacilityTbl",
                newName: "IX_SchoolFacilityTbl_FacilityID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolFacilityTbl_FacilityTbl_FacilityID",
                table: "SchoolFacilityTbl",
                column: "FacilityID",
                principalTable: "FacilityTbl",
                principalColumn: "FacilityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolFacilityTbl_FacilityTbl_FacilityID",
                table: "SchoolFacilityTbl");

            migrationBuilder.RenameColumn(
                name: "FacilityID",
                table: "SchoolFacilityTbl",
                newName: "FaclilityID");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolFacilityTbl_FacilityID",
                table: "SchoolFacilityTbl",
                newName: "IX_SchoolFacilityTbl_FaclilityID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolFacilityTbl_FacilityTbl_FaclilityID",
                table: "SchoolFacilityTbl",
                column: "FaclilityID",
                principalTable: "FacilityTbl",
                principalColumn: "FacilityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
