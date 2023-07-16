﻿// <auto-generated />
using System;
using CRVS.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRVS.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230715213253_f1")]
    partial class f1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRVS.Core.Models.BirthCertificate", b =>
                {
                    b.Property<Guid>("BirthCertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Alive")
                        .HasColumnType("int");

                    b.Property<string>("AllPDFs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Approval")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("BHour")
                        .HasColumnType("time");

                    b.Property<DateTime>("BOD")
                        .HasColumnType("datetime2");

                    b.Property<string>("BODText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BabyWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BirthOccurredBy")
                        .HasColumnType("int");

                    b.Property<string>("BirthPerformerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthPerformerWorkingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BirthType")
                        .HasColumnType("int");

                    b.Property<int>("BornAliveThenDied")
                        .HasColumnType("int");

                    b.Property<int>("BornDisable")
                        .HasColumnType("int");

                    b.Property<string>("CertificateNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CivilStatusDirectorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Creator")
                        .HasColumnType("bit");

                    b.Property<int>("DOH")
                        .HasColumnType("int");

                    b.Property<int>("District")
                        .HasColumnType("int");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<int>("DurationOfPregnancy")
                        .HasColumnType("int");

                    b.Property<string>("FamilyDOH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGovernorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyHomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyMahala")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyNahiah")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyPHC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilySector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyZigag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("FatherBOD")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherFName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherJob")
                        .HasColumnType("int");

                    b.Property<string>("FatherLName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherMName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherMobile")
                        .HasColumnType("int");

                    b.Property<int>("FatherNationality")
                        .HasColumnType("int");

                    b.Property<int>("FatherReligion")
                        .HasColumnType("int");

                    b.Property<bool>("FirstStage")
                        .HasColumnType("bit");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Governorate")
                        .HasColumnType("int");

                    b.Property<string>("GovernorateCivilStatusDirectorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelthID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalManagerSig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgBirthCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgFatherUnifiedNationalIdBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgFatherUnifiedNationalIdFront")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMarriageCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMotherUnifiedNationalIdBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMotherUnifiedNationalIdFront")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgResidencyCardBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgResidencyCardFront")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformerJobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("bit");

                    b.Property<string>("IsDisabledType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KinshipOfTheNewborn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicenseNo")
                        .HasColumnType("int");

                    b.Property<string>("LicenseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("MotherBOD")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotherFName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherJob")
                        .HasColumnType("int");

                    b.Property<string>("MotherLName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherMName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherMobile")
                        .HasColumnType("int");

                    b.Property<int>("MotherNationality")
                        .HasColumnType("int");

                    b.Property<int>("MotherReligion")
                        .HasColumnType("int");

                    b.Property<int>("Nahia")
                        .HasColumnType("int");

                    b.Property<int>("NationalID")
                        .HasColumnType("int");

                    b.Property<int>("NationalIdFor")
                        .HasColumnType("int");

                    b.Property<int>("NoAbortion")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfBirth")
                        .HasColumnType("int");

                    b.Property<string>("PageNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceOfBirth")
                        .HasColumnType("int");

                    b.Property<string>("QrCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RationCard")
                        .HasColumnType("int");

                    b.Property<string>("RecordNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Relative")
                        .HasColumnType("bit");

                    b.Property<bool>("SecondStage")
                        .HasColumnType("bit");

                    b.Property<int>("StillBirth")
                        .HasColumnType("int");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BirthCertificateId");

                    b.ToTable("BirthCertificates");
                });

            modelBuilder.Entity("CRVS.Core.Models.DisabledType", b =>
                {
                    b.Property<int>("DisabledTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisabledTypeId"));

                    b.Property<string>("DisabledTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisabledTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisabledTypeId");

                    b.ToTable("DisabledTypes");
                });

            modelBuilder.Entity("CRVS.Core.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("CRVS.Core.Models.Doh", b =>
                {
                    b.Property<int>("DohId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DohId"));

                    b.Property<int>("DohCode")
                        .HasColumnType("int");

                    b.Property<string>("DohName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.HasKey("DohId");

                    b.HasIndex("GovernorateId");

                    b.ToTable("Dohs");
                });

            modelBuilder.Entity("CRVS.Core.Models.FacilityType", b =>
                {
                    b.Property<int>("FacilityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityTypeId"));

                    b.Property<string>("FacilityTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityTypeId");

                    b.ToTable("FacilityTypes");
                });

            modelBuilder.Entity("CRVS.Core.Models.Governorate", b =>
                {
                    b.Property<int>("GovernorateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GovernorateId"));

                    b.Property<int>("GovernorateCode")
                        .HasColumnType("int");

                    b.Property<string>("GovernorateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GovernorateId");

                    b.ToTable("Governorates");
                });

            modelBuilder.Entity("CRVS.Core.Models.HealthInstitution", b =>
                {
                    b.Property<int>("HealthInstitutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthInstitutionId"));

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityTypeId")
                        .HasColumnType("int");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("HealthInstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HealthInstitutionId");

                    b.ToTable("HealthInstitutions");
                });

            modelBuilder.Entity("CRVS.Core.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("CRVS.Core.Models.Nahia", b =>
                {
                    b.Property<int>("NahiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NahiaId"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("NahiaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NahiaId");

                    b.ToTable("Nahias");
                });

            modelBuilder.Entity("CRVS.Core.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityId"));

                    b.Property<string>("NationalityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("CRVS.Core.Models.Religion", b =>
                {
                    b.Property<int>("ReligionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReligionId"));

                    b.Property<string>("ReligionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReligionId");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CRVS.Core.Models.Doh", b =>
                {
                    b.HasOne("CRVS.Core.Models.Governorate", "governorate")
                        .WithMany()
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("governorate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}