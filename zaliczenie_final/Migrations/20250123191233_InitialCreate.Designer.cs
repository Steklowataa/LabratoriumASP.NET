﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zaliczenie_final.Context;

#nullable disable

namespace zaliczenie_final.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250123191233_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.12");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c11cf6cf-fb58-4fcc-a830-532b7e2099be",
                            ConcurrencyStamp = "c11cf6cf-fb58-4fcc-a830-532b7e2099be",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7b3f14b5-9fea-4f81-8307-11d8c46e2caf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f84b3ae9-6478-4a99-a29a-4fdcad62bdac",
                            Email = "adam@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADAM@WSEI.EDU.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEGUCfJVz+MWEgGJ4QW53SrDeMV5pYhbMkhxN0RLmw09syBZYtF/wzZ9NG4/eFc4AMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba581100-eee3-4f55-9ae3-c697368dc78c",
                            TwoFactorEnabled = false,
                            UserName = "adam"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "7b3f14b5-9fea-4f81-8307-11d8c46e2caf",
                            RoleId = "c11cf6cf-fb58-4fcc-a830-532b7e2099be"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("CountryName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("country_name")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.RankingCriterion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("CriteriaName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("criteria_name")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("RankingSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ranking_system_id")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id");

                    b.HasIndex("RankingSystemId");

                    b.ToTable("ranking_criteria", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.RankingSystem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("SystemName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("system_name")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id");

                    b.ToTable("ranking_system", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.University", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int?>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("country_id")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("UniversityName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("university_name")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("university", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.UniversityRankingYear", b =>
                {
                    b.Property<int?>("RankingCriteriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ranking_criteria_id")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("Score")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("score")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("university_id")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("year")
                        .HasDefaultValueSql("NULL");

                    b.HasIndex("RankingCriteriaId");

                    b.HasIndex("UniversityId");

                    b.ToTable("university_ranking_year", (string)null);
                });

            modelBuilder.Entity("zaliczenie_final.Entities.UniversityYear", b =>
                {
                    b.Property<int?>("NumStudents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("num_students")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("PctFemaleStudents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("pct_female_students")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("PctInternationalStudents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("pct_international_students")
                        .HasDefaultValueSql("NULL");

                    b.Property<double?>("StudentStaffRatio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasColumnName("student_staff_ratio")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("university_id")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("year")
                        .HasDefaultValueSql("NULL");

                    b.HasIndex("UniversityId");

                    b.ToTable("university_year", (string)null);
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

            modelBuilder.Entity("zaliczenie_final.Entities.RankingCriterion", b =>
                {
                    b.HasOne("zaliczenie_final.Entities.RankingSystem", "RankingSystem")
                        .WithMany("RankingCriteria")
                        .HasForeignKey("RankingSystemId");

                    b.Navigation("RankingSystem");
                });

            modelBuilder.Entity("zaliczenie_final.Entities.University", b =>
                {
                    b.HasOne("zaliczenie_final.Entities.Country", "Country")
                        .WithMany("Universities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("zaliczenie_final.Entities.UniversityRankingYear", b =>
                {
                    b.HasOne("zaliczenie_final.Entities.RankingCriterion", "RankingCriteria")
                        .WithMany()
                        .HasForeignKey("RankingCriteriaId");

                    b.HasOne("zaliczenie_final.Entities.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId");

                    b.Navigation("RankingCriteria");

                    b.Navigation("University");
                });

            modelBuilder.Entity("zaliczenie_final.Entities.UniversityYear", b =>
                {
                    b.HasOne("zaliczenie_final.Entities.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("zaliczenie_final.Entities.Country", b =>
                {
                    b.Navigation("Universities");
                });

            modelBuilder.Entity("zaliczenie_final.Entities.RankingSystem", b =>
                {
                    b.Navigation("RankingCriteria");
                });
#pragma warning restore 612, 618
        }
    }
}
