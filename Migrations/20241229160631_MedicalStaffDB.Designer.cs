﻿// <auto-generated />
using System;
using HospitalManagment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Managment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241229160631_MedicalStaffDB")]
    partial class MedicalStaffDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HospitalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalManagment.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alex@gmail.com",
                            PasswordHash = "$2a$11$L3/d85LOzJfjy5675RoK/eboyC.cPWLWT6CiqI2MfZZcxqyFdJ6D.",
                            Username = "Alex"
                        },
                        new
                        {
                            Id = 2,
                            Email = "andrei@gmail.com",
                            PasswordHash = "$2a$11$PV77W8GBULlBDdHDPjzrqOxu5SapTvdp0Q4MBI/HXng.fk0DUO7T2",
                            Username = "Andrei"
                        },
                        new
                        {
                            Id = 3,
                            Email = "marius@gmail.com",
                            PasswordHash = "$2a$11$bLvSXelGYAoFKDk1cEblauRteYRotIEaizG9iW/TCTSs7Ymsk9H72",
                            Username = "Marius"
                        });
                });

            modelBuilder.Entity("HospitalManagment.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Accreditations")
                        .HasColumnType("TEXT");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FoundedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainDoctor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            DepartmentName = "Cardiology"
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 1,
                            DepartmentName = "Neurology"
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 2,
                            DepartmentName = "Pediatrics"
                        },
                        new
                        {
                            Id = 4,
                            AdminId = 3,
                            DepartmentName = "Dermatology"
                        });
                });

            modelBuilder.Entity("HospitalManagment.Models.MedicalStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("MedicalStaffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            DepartmentId = 1,
                            PasswordHash = "$2a$12$RvBnjdK5vod8qb02w0ZxzuafaeDZ5hUyjM.x2E1tEsardDL5tiA0y",
                            Username = "Sara"
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 1,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$9Vhk6FakLIPw2oqITiyWd.5yT1RKRbg7FwZNBurvD9nLciLfmjoWm",
                            Username = "Carina"
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 1,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$xJEYrgnETzvowSCYAtPdlu13jhRZ6P02EZDF9d/XAOpW2Tq1nuSSi",
                            Username = "Flavius"
                        },
                        new
                        {
                            Id = 4,
                            AdminId = 1,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$u5CL6ypkZPwLpRoMoN2GoO4pQ2N8HzDdvW1QD7zuIDDw9/lRnGlYy",
                            Username = "George"
                        },
                        new
                        {
                            Id = 5,
                            AdminId = 1,
                            DepartmentId = 2,
                            PasswordHash = "$2a$11$2JQHdcU.6ZfS.WX5pLVPluy7uJq4kB/Cn0OqpwXpzKjcb8mL1Mu/S",
                            Username = "Maria"
                        },
                        new
                        {
                            Id = 6,
                            AdminId = 1,
                            DepartmentId = 2,
                            PasswordHash = "$2a$11$n2lPnRp6jVuKY7219WD5seyMEQzq45jxc4AZzLPSyy5opKe2ypq7O",
                            Username = "Ilie"
                        },
                        new
                        {
                            Id = 7,
                            AdminId = 1,
                            DepartmentId = 2,
                            PasswordHash = "$2a$11$FgkiwL3dvqrvu7O9mKuGaue8MucA5ImP283mKDCdo0kbY3fh7Jsum",
                            Username = "Vlad"
                        },
                        new
                        {
                            Id = 8,
                            AdminId = 2,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$G6tVf7hR8ni7trHf0WZoXOUH7UbjDomgwos3Hrp1jMI7asE0vwM6a",
                            Username = "Cristi"
                        },
                        new
                        {
                            Id = 9,
                            AdminId = 2,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$eU0vuoBKQt5kOMVx3SPO8upqtosPy/tFKrFvMgUbAfvRem/FB5dcq",
                            Username = "Serban"
                        },
                        new
                        {
                            Id = 10,
                            AdminId = 2,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$o0UR5DQiiQq9zFm/QG28I.QCgxqZtgKhtPuklssaOvI7SiqHn3Zje",
                            Username = "Tudor"
                        },
                        new
                        {
                            Id = 11,
                            AdminId = 2,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$g4zc2Jfj3I3RTUvft9Xj8elsh/Wz9Sdi8UW22cApp.tFf6RdPinCy",
                            Username = "Alexandra"
                        },
                        new
                        {
                            Id = 12,
                            AdminId = 3,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$qrl93QvU3uPGlQIvIkfTQO3BrvYRGUC6Y/u0h7IKp4m9kPRNR/HG6",
                            Username = "Marc"
                        },
                        new
                        {
                            Id = 13,
                            AdminId = 3,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$sTmnkC5GP3Dh49YA8Hix0edhTrpKNhuWAm7MN0uqle6c5CVTOaOYe",
                            Username = "Diana"
                        },
                        new
                        {
                            Id = 14,
                            AdminId = 3,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$pau9CtSFoAs.mBn83PNW1OkonJWEheD4UKGCRHuOIEyLcmUDsHfsK",
                            Username = "Ana"
                        },
                        new
                        {
                            Id = 15,
                            AdminId = 3,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$cp74W4PcfUh6FiAvAgDon.ihBt2cbBDk5hB1Vtb5oY2tnxtmntvVe",
                            Username = "Dan"
                        },
                        new
                        {
                            Id = 16,
                            AdminId = 3,
                            DepartmentId = 1,
                            PasswordHash = "$2a$11$vreICMp6.M3Z9MwUEY/TOupC05lYNJASV5S63x9LbYERBFPGtCI8G",
                            Username = "Filip"
                        });
                });

            modelBuilder.Entity("HospitalManagment.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedDoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MedicalRecord")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssignedDoctorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalManagment.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

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

            modelBuilder.Entity("Hospital", b =>
                {
                    b.HasOne("HospitalManagment.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("HospitalManagment.Models.Department", b =>
                {
                    b.HasOne("HospitalManagment.Models.Admin", "Admin")
                        .WithMany("Departments")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("HospitalManagment.Models.MedicalStaff", b =>
                {
                    b.HasOne("HospitalManagment.Models.Department", null)
                        .WithMany("MedicalStaffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagment.Models.Patient", b =>
                {
                    b.HasOne("HospitalManagment.Models.MedicalStaff", "AssignedDoctor")
                        .WithMany()
                        .HasForeignKey("AssignedDoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagment.Models.Department", "Departments")
                        .WithMany("Patients")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedDoctor");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HospitalManagment.Models.User", b =>
                {
                    b.HasOne("HospitalManagment.Models.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Departments");
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
                    b.HasOne("HospitalManagment.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HospitalManagment.Models.User", null)
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

                    b.HasOne("HospitalManagment.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HospitalManagment.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagment.Models.Admin", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HospitalManagment.Models.Department", b =>
                {
                    b.Navigation("MedicalStaffs");

                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}