﻿// <auto-generated />
using System;
using LoginSignup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginSignup.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LoginSignup.Models.Enrollment", b =>
                {
                    b.Property<string>("EnrollmentID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CourseID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("EnrollStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("LoginSignup.Models.PasswordHistory", b =>
                {
                    b.Property<string>("PasswordID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OldPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("PasswordID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("PasswordHistories");
                });

            modelBuilder.Entity("LoginSignup.Models.Profile", b =>
                {
                    b.Property<string>("ProfileID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("DOB")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Stream")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("ProfileID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("LoginSignup.Models.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("varchar(95)");

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("UnblockRequest")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UserLastLogin")
                        .HasColumnType("datetime");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LoginSignup.Models.Enrollment", b =>
                {
                    b.HasOne("LoginSignup.Models.User", "User")
                        .WithOne("Enrollment")
                        .HasForeignKey("LoginSignup.Models.Enrollment", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LoginSignup.Models.PasswordHistory", b =>
                {
                    b.HasOne("LoginSignup.Models.User", "User")
                        .WithOne("PasswordHistory")
                        .HasForeignKey("LoginSignup.Models.PasswordHistory", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LoginSignup.Models.Profile", b =>
                {
                    b.HasOne("LoginSignup.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("LoginSignup.Models.Profile", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LoginSignup.Models.User", b =>
                {
                    b.Navigation("Enrollment")
                        .IsRequired();

                    b.Navigation("PasswordHistory")
                        .IsRequired();

                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
