﻿// <auto-generated />
using System;
using FutureStageApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FutureStageApp.Migrations
{
    [DbContext(typeof(FutureStageAppContext))]
    [Migration("20221026164406_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FutureStageApp.Models.AddmissionConfirmation", b =>
                {
                    b.Property<long>("AddmissionConfirmationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("AddmissionEnquiryID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("EnquiryID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Remark")
                        .HasColumnType("bit");

                    b.HasKey("AddmissionConfirmationID");

                    b.HasIndex("AddmissionEnquiryID");

                    b.HasIndex("EnquiryID");

                    b.ToTable("AddmissionConfirmationTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionEnquiry", b =>
                {
                    b.Property<long>("AddmissionEnquiryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EnquiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnquiryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ParentID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("AddmissionEnquiryID");

                    b.HasIndex("ParentID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("AddmissionEnquiryTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionPrerequisite", b =>
                {
                    b.Property<long>("AddmissionPrerequisiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("PrerequisiteDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrerequisiteTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("AddmissionPrerequisiteID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("AddmissionPrerequisiteTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionProcess", b =>
                {
                    b.Property<long>("AddmissionProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ProcessDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("AddmissionProcessID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("AddmissionProcessTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Area", b =>
                {
                    b.Property<long>("AreaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.HasKey("AreaID");

                    b.HasIndex("CityID");

                    b.ToTable("AreaTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.ConfirmedEnquiry", b =>
                {
                    b.Property<long>("AddmissionEnquiryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EnquiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnquiryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ParentID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("AddmissionEnquiryID");

                    b.HasIndex("ParentID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("ConfirmedEnquiryTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.EducationBoard", b =>
                {
                    b.Property<long>("EducationBoardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("EducationBoardDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationBoardTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationBoardID");

                    b.ToTable("EducationBoardTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Enquiry", b =>
                {
                    b.Property<long>("EnquiryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EnquiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnquiryDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ParentID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.HasKey("EnquiryID");

                    b.HasIndex("ParentID");

                    b.HasIndex("SchoolID");

                    b.ToTable("EnquiryTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Facility", b =>
                {
                    b.Property<long>("FacilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FaclilityDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaclilityTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityID");

                    b.ToTable("FacilityTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.FeeHead", b =>
                {
                    b.Property<long>("FeeHeadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FeeHeadDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeeHeadTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeeHeadID");

                    b.ToTable("FeeHeadTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.GeneralEnquiryReply", b =>
                {
                    b.Property<long>("GeneralEnquiryReplyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("EnquiryID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ReplyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReplyDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneralEnquiryReplyID");

                    b.HasIndex("EnquiryID");

                    b.ToTable("GeneralEnquiryReplyTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Medium", b =>
                {
                    b.Property<long>("MediumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("MediumTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediumID");

                    b.ToTable("MediumTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Parent", b =>
                {
                    b.Property<long>("ParentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentID");

                    b.ToTable("ParentTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Quota", b =>
                {
                    b.Property<long>("QuotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("QuotaDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuotaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuotaID");

                    b.ToTable("QuotaTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.School", b =>
                {
                    b.Property<long>("SchoolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AreaID")
                        .HasColumnType("bigint");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolID");

                    b.HasIndex("AreaID");

                    b.ToTable("SchoolTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolAchivement", b =>
                {
                    b.Property<long>("SchoolAchivementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SchoolAchivementDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolAchivementID");

                    b.HasIndex("SchoolID");

                    b.ToTable("SchoolAchivementTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolFacility", b =>
                {
                    b.Property<long>("SchoolFacilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FaclilityDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FaclilityID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.HasKey("SchoolFacilityID");

                    b.HasIndex("FaclilityID");

                    b.HasIndex("SchoolID");

                    b.ToTable("SchoolFacilityTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolStandard", b =>
                {
                    b.Property<long>("SchoolStandardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("IntakeCapacity")
                        .HasColumnType("int");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.Property<long>("StandardID")
                        .HasColumnType("bigint");

                    b.HasKey("SchoolStandardID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("StandardID");

                    b.ToTable("SchoolStadardTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.SiteAdmin", b =>
                {
                    b.Property<long>("SiteAdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteAdminID");

                    b.ToTable("SiteAdminTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.Standard", b =>
                {
                    b.Property<long>("StandardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("StandardDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandardTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StandardID");

                    b.ToTable("SatndardTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.StandardFees", b =>
                {
                    b.Property<long>("StandardFeesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("FeeHeadID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("StandardFeesID");

                    b.HasIndex("FeeHeadID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("StandardFeesTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.StandardSeatQuota", b =>
                {
                    b.Property<long>("StandardSeatQuotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<long>("QuotaID")
                        .HasColumnType("bigint");

                    b.Property<long>("SchoolStandardID")
                        .HasColumnType("bigint");

                    b.HasKey("StandardSeatQuotaID");

                    b.HasIndex("QuotaID");

                    b.HasIndex("SchoolStandardID");

                    b.ToTable("StandardSeatQuotaTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.ToTable("StateTbl");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionConfirmation", b =>
                {
                    b.HasOne("FutureStageApp.Models.AddmissionEnquiry", "AddmissionEnquiry")
                        .WithMany()
                        .HasForeignKey("AddmissionEnquiryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.Enquiry", null)
                        .WithMany("AddmissionConfirmations")
                        .HasForeignKey("EnquiryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AddmissionEnquiry");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionEnquiry", b =>
                {
                    b.HasOne("FutureStageApp.Models.Parent", "Parent")
                        .WithMany("AddmissionEnquiries")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany("AddmissionEnquiries")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany("AddmissionEnquiries")
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("School");

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionPrerequisite", b =>
                {
                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany("AddmissionPrerequisites")
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.AddmissionProcess", b =>
                {
                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany("AddmissionProcesses")
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.Area", b =>
                {
                    b.HasOne("FutureStageApp.Models.City", "City")
                        .WithMany("Areas")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FutureStageApp.Models.City", b =>
                {
                    b.HasOne("FutureStageApp.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("FutureStageApp.Models.ConfirmedEnquiry", b =>
                {
                    b.HasOne("FutureStageApp.Models.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany()
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("School");

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.Enquiry", b =>
                {
                    b.HasOne("FutureStageApp.Models.Parent", "Parent")
                        .WithMany("Enquiries")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany("Enquiries")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("School");
                });

            modelBuilder.Entity("FutureStageApp.Models.GeneralEnquiryReply", b =>
                {
                    b.HasOne("FutureStageApp.Models.Enquiry", "Enquiry")
                        .WithMany("GeneralEnquiryReplies")
                        .HasForeignKey("EnquiryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Enquiry");
                });

            modelBuilder.Entity("FutureStageApp.Models.School", b =>
                {
                    b.HasOne("FutureStageApp.Models.Area", "Area")
                        .WithMany("Schools")
                        .HasForeignKey("AreaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolAchivement", b =>
                {
                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany("SchoolAchivements")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolFacility", b =>
                {
                    b.HasOne("FutureStageApp.Models.Facility", "Facility")
                        .WithMany("SchoolFacilities")
                        .HasForeignKey("FaclilityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany("SchoolFacilities")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("School");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolStandard", b =>
                {
                    b.HasOne("FutureStageApp.Models.School", "School")
                        .WithMany("SchoolStandards")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.Standard", "Standard")
                        .WithMany("SchoolStandards")
                        .HasForeignKey("StandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("FutureStageApp.Models.StandardFees", b =>
                {
                    b.HasOne("FutureStageApp.Models.FeeHead", "FeeHead")
                        .WithMany("StandardFees")
                        .HasForeignKey("FeeHeadID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany("StandardFees")
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FeeHead");

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.StandardSeatQuota", b =>
                {
                    b.HasOne("FutureStageApp.Models.Quota", "Quota")
                        .WithMany("StandardSeatQuotas")
                        .HasForeignKey("QuotaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FutureStageApp.Models.SchoolStandard", "SchoolStandard")
                        .WithMany("StandardSeatQuotas")
                        .HasForeignKey("SchoolStandardID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Quota");

                    b.Navigation("SchoolStandard");
                });

            modelBuilder.Entity("FutureStageApp.Models.Area", b =>
                {
                    b.Navigation("Schools");
                });

            modelBuilder.Entity("FutureStageApp.Models.City", b =>
                {
                    b.Navigation("Areas");
                });

            modelBuilder.Entity("FutureStageApp.Models.Enquiry", b =>
                {
                    b.Navigation("AddmissionConfirmations");

                    b.Navigation("GeneralEnquiryReplies");
                });

            modelBuilder.Entity("FutureStageApp.Models.Facility", b =>
                {
                    b.Navigation("SchoolFacilities");
                });

            modelBuilder.Entity("FutureStageApp.Models.FeeHead", b =>
                {
                    b.Navigation("StandardFees");
                });

            modelBuilder.Entity("FutureStageApp.Models.Parent", b =>
                {
                    b.Navigation("AddmissionEnquiries");

                    b.Navigation("Enquiries");
                });

            modelBuilder.Entity("FutureStageApp.Models.Quota", b =>
                {
                    b.Navigation("StandardSeatQuotas");
                });

            modelBuilder.Entity("FutureStageApp.Models.School", b =>
                {
                    b.Navigation("AddmissionEnquiries");

                    b.Navigation("Enquiries");

                    b.Navigation("SchoolAchivements");

                    b.Navigation("SchoolFacilities");

                    b.Navigation("SchoolStandards");
                });

            modelBuilder.Entity("FutureStageApp.Models.SchoolStandard", b =>
                {
                    b.Navigation("AddmissionEnquiries");

                    b.Navigation("AddmissionPrerequisites");

                    b.Navigation("AddmissionProcesses");

                    b.Navigation("StandardFees");

                    b.Navigation("StandardSeatQuotas");
                });

            modelBuilder.Entity("FutureStageApp.Models.Standard", b =>
                {
                    b.Navigation("SchoolStandards");
                });

            modelBuilder.Entity("FutureStageApp.Models.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
