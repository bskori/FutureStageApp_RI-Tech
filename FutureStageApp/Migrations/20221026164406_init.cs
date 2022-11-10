using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureStageApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationBoardTbl",
                columns: table => new
                {
                    EducationBoardID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationBoardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationBoardDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationBoardTbl", x => x.EducationBoardID);
                });

            migrationBuilder.CreateTable(
                name: "FacilityTbl",
                columns: table => new
                {
                    FacilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaclilityTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaclilityDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityTbl", x => x.FacilityID);
                });

            migrationBuilder.CreateTable(
                name: "FeeHeadTbl",
                columns: table => new
                {
                    FeeHeadID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeHeadTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeeHeadDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeHeadTbl", x => x.FeeHeadID);
                });

            migrationBuilder.CreateTable(
                name: "MediumTbl",
                columns: table => new
                {
                    MediumID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediumTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediumTbl", x => x.MediumID);
                });

            migrationBuilder.CreateTable(
                name: "ParentTbl",
                columns: table => new
                {
                    ParentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentTbl", x => x.ParentID);
                });

            migrationBuilder.CreateTable(
                name: "QuotaTbl",
                columns: table => new
                {
                    QuotaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotaDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotaTbl", x => x.QuotaID);
                });

            migrationBuilder.CreateTable(
                name: "SatndardTbl",
                columns: table => new
                {
                    StandardID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatndardTbl", x => x.StandardID);
                });

            migrationBuilder.CreateTable(
                name: "SiteAdminTbl",
                columns: table => new
                {
                    SiteAdminID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAdminTbl", x => x.SiteAdminID);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_StateTbl_StateID",
                        column: x => x.StateID,
                        principalTable: "StateTbl",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaTbl",
                columns: table => new
                {
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaTbl", x => x.AreaID);
                    table.ForeignKey(
                        name: "FK_AreaTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTbl",
                columns: table => new
                {
                    SchoolID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTbl", x => x.SchoolID);
                    table.ForeignKey(
                        name: "FK_SchoolTbl_AreaTbl_AreaID",
                        column: x => x.AreaID,
                        principalTable: "AreaTbl",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnquiryTbl",
                columns: table => new
                {
                    EnquiryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnquiryDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnquiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentID = table.Column<long>(type: "bigint", nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnquiryTbl", x => x.EnquiryID);
                    table.ForeignKey(
                        name: "FK_EnquiryTbl_ParentTbl_ParentID",
                        column: x => x.ParentID,
                        principalTable: "ParentTbl",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnquiryTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolAchivementTbl",
                columns: table => new
                {
                    SchoolAchivementID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolAchivementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolAchivementTbl", x => x.SchoolAchivementID);
                    table.ForeignKey(
                        name: "FK_SchoolAchivementTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolFacilityTbl",
                columns: table => new
                {
                    SchoolFacilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false),
                    FaclilityID = table.Column<long>(type: "bigint", nullable: false),
                    FaclilityDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolFacilityTbl", x => x.SchoolFacilityID);
                    table.ForeignKey(
                        name: "FK_SchoolFacilityTbl_FacilityTbl_FaclilityID",
                        column: x => x.FaclilityID,
                        principalTable: "FacilityTbl",
                        principalColumn: "FacilityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolFacilityTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolStadardTbl",
                columns: table => new
                {
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardID = table.Column<long>(type: "bigint", nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false),
                    IntakeCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolStadardTbl", x => x.SchoolStandardID);
                    table.ForeignKey(
                        name: "FK_SchoolStadardTbl_SatndardTbl_StandardID",
                        column: x => x.StandardID,
                        principalTable: "SatndardTbl",
                        principalColumn: "StandardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolStadardTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralEnquiryReplyTbl",
                columns: table => new
                {
                    GeneralEnquiryReplyID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnquiryID = table.Column<long>(type: "bigint", nullable: false),
                    ReplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReplyDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralEnquiryReplyTbl", x => x.GeneralEnquiryReplyID);
                    table.ForeignKey(
                        name: "FK_GeneralEnquiryReplyTbl_EnquiryTbl_EnquiryID",
                        column: x => x.EnquiryID,
                        principalTable: "EnquiryTbl",
                        principalColumn: "EnquiryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddmissionEnquiryTbl",
                columns: table => new
                {
                    AddmissionEnquiryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<long>(type: "bigint", nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false),
                    EnquiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    EnquiryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddmissionEnquiryTbl", x => x.AddmissionEnquiryID);
                    table.ForeignKey(
                        name: "FK_AddmissionEnquiryTbl_ParentTbl_ParentID",
                        column: x => x.ParentID,
                        principalTable: "ParentTbl",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddmissionEnquiryTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddmissionEnquiryTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddmissionPrerequisiteTbl",
                columns: table => new
                {
                    AddmissionPrerequisiteID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrerequisiteTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    PrerequisiteDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddmissionPrerequisiteTbl", x => x.AddmissionPrerequisiteID);
                    table.ForeignKey(
                        name: "FK_AddmissionPrerequisiteTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddmissionProcessTbl",
                columns: table => new
                {
                    AddmissionProcessID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    ProcessTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddmissionProcessTbl", x => x.AddmissionProcessID);
                    table.ForeignKey(
                        name: "FK_AddmissionProcessTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfirmedEnquiryTbl",
                columns: table => new
                {
                    AddmissionEnquiryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<long>(type: "bigint", nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false),
                    EnquiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    EnquiryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmedEnquiryTbl", x => x.AddmissionEnquiryID);
                    table.ForeignKey(
                        name: "FK_ConfirmedEnquiryTbl_ParentTbl_ParentID",
                        column: x => x.ParentID,
                        principalTable: "ParentTbl",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfirmedEnquiryTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfirmedEnquiryTbl_SchoolTbl_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolTbl",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StandardFeesTbl",
                columns: table => new
                {
                    StandardFeesID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    FeeHeadID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardFeesTbl", x => x.StandardFeesID);
                    table.ForeignKey(
                        name: "FK_StandardFeesTbl_FeeHeadTbl_FeeHeadID",
                        column: x => x.FeeHeadID,
                        principalTable: "FeeHeadTbl",
                        principalColumn: "FeeHeadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StandardFeesTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StandardSeatQuotaTbl",
                columns: table => new
                {
                    StandardSeatQuotaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolStandardID = table.Column<long>(type: "bigint", nullable: false),
                    QuotaID = table.Column<long>(type: "bigint", nullable: false),
                    NoOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardSeatQuotaTbl", x => x.StandardSeatQuotaID);
                    table.ForeignKey(
                        name: "FK_StandardSeatQuotaTbl_QuotaTbl_QuotaID",
                        column: x => x.QuotaID,
                        principalTable: "QuotaTbl",
                        principalColumn: "QuotaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StandardSeatQuotaTbl_SchoolStadardTbl_SchoolStandardID",
                        column: x => x.SchoolStandardID,
                        principalTable: "SchoolStadardTbl",
                        principalColumn: "SchoolStandardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddmissionConfirmationTbl",
                columns: table => new
                {
                    AddmissionConfirmationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddmissionEnquiryID = table.Column<long>(type: "bigint", nullable: false),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<bool>(type: "bit", nullable: false),
                    EnquiryID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddmissionConfirmationTbl", x => x.AddmissionConfirmationID);
                    table.ForeignKey(
                        name: "FK_AddmissionConfirmationTbl_AddmissionEnquiryTbl_AddmissionEnquiryID",
                        column: x => x.AddmissionEnquiryID,
                        principalTable: "AddmissionEnquiryTbl",
                        principalColumn: "AddmissionEnquiryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddmissionConfirmationTbl_EnquiryTbl_EnquiryID",
                        column: x => x.EnquiryID,
                        principalTable: "EnquiryTbl",
                        principalColumn: "EnquiryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionConfirmationTbl_AddmissionEnquiryID",
                table: "AddmissionConfirmationTbl",
                column: "AddmissionEnquiryID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionConfirmationTbl_EnquiryID",
                table: "AddmissionConfirmationTbl",
                column: "EnquiryID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionEnquiryTbl_ParentID",
                table: "AddmissionEnquiryTbl",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionEnquiryTbl_SchoolID",
                table: "AddmissionEnquiryTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionEnquiryTbl_SchoolStandardID",
                table: "AddmissionEnquiryTbl",
                column: "SchoolStandardID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionPrerequisiteTbl_SchoolStandardID",
                table: "AddmissionPrerequisiteTbl",
                column: "SchoolStandardID");

            migrationBuilder.CreateIndex(
                name: "IX_AddmissionProcessTbl_SchoolStandardID",
                table: "AddmissionProcessTbl",
                column: "SchoolStandardID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaTbl_CityID",
                table: "AreaTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_ConfirmedEnquiryTbl_ParentID",
                table: "ConfirmedEnquiryTbl",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_ConfirmedEnquiryTbl_SchoolID",
                table: "ConfirmedEnquiryTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_ConfirmedEnquiryTbl_SchoolStandardID",
                table: "ConfirmedEnquiryTbl",
                column: "SchoolStandardID");

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryTbl_ParentID",
                table: "EnquiryTbl",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_EnquiryTbl_SchoolID",
                table: "EnquiryTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralEnquiryReplyTbl_EnquiryID",
                table: "GeneralEnquiryReplyTbl",
                column: "EnquiryID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolAchivementTbl_SchoolID",
                table: "SchoolAchivementTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolFacilityTbl_FaclilityID",
                table: "SchoolFacilityTbl",
                column: "FaclilityID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolFacilityTbl_SchoolID",
                table: "SchoolFacilityTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolStadardTbl_SchoolID",
                table: "SchoolStadardTbl",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolStadardTbl_StandardID",
                table: "SchoolStadardTbl",
                column: "StandardID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTbl_AreaID",
                table: "SchoolTbl",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardFeesTbl_FeeHeadID",
                table: "StandardFeesTbl",
                column: "FeeHeadID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardFeesTbl_SchoolStandardID",
                table: "StandardFeesTbl",
                column: "SchoolStandardID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardSeatQuotaTbl_QuotaID",
                table: "StandardSeatQuotaTbl",
                column: "QuotaID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardSeatQuotaTbl_SchoolStandardID",
                table: "StandardSeatQuotaTbl",
                column: "SchoolStandardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddmissionConfirmationTbl");

            migrationBuilder.DropTable(
                name: "AddmissionPrerequisiteTbl");

            migrationBuilder.DropTable(
                name: "AddmissionProcessTbl");

            migrationBuilder.DropTable(
                name: "ConfirmedEnquiryTbl");

            migrationBuilder.DropTable(
                name: "EducationBoardTbl");

            migrationBuilder.DropTable(
                name: "GeneralEnquiryReplyTbl");

            migrationBuilder.DropTable(
                name: "MediumTbl");

            migrationBuilder.DropTable(
                name: "SchoolAchivementTbl");

            migrationBuilder.DropTable(
                name: "SchoolFacilityTbl");

            migrationBuilder.DropTable(
                name: "SiteAdminTbl");

            migrationBuilder.DropTable(
                name: "StandardFeesTbl");

            migrationBuilder.DropTable(
                name: "StandardSeatQuotaTbl");

            migrationBuilder.DropTable(
                name: "AddmissionEnquiryTbl");

            migrationBuilder.DropTable(
                name: "EnquiryTbl");

            migrationBuilder.DropTable(
                name: "FacilityTbl");

            migrationBuilder.DropTable(
                name: "FeeHeadTbl");

            migrationBuilder.DropTable(
                name: "QuotaTbl");

            migrationBuilder.DropTable(
                name: "SchoolStadardTbl");

            migrationBuilder.DropTable(
                name: "ParentTbl");

            migrationBuilder.DropTable(
                name: "SatndardTbl");

            migrationBuilder.DropTable(
                name: "SchoolTbl");

            migrationBuilder.DropTable(
                name: "AreaTbl");

            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");
        }
    }
}
