﻿// <auto-generated />
using System;
using AdaptItAcademy.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdaptItAcademy.DataAccess.Migrations
{
    [DbContext(typeof(AcademyDbContext))]
    [Migration("20210830084156_AddValidation")]
    partial class AddValidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("LastDateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsLeft")
                        .HasColumnType("int");

                    b.Property<string>("TrainingVenue")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Dietary", b =>
                {
                    b.Property<int>("DietaryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingID")
                        .HasColumnType("int");

                    b.HasKey("DietaryID");

                    b.HasIndex("TrainingID");

                    b.ToTable("Dietary");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Training", b =>
                {
                    b.Property<int>("TrainingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingID");

                    b.HasIndex("CourseID");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.TrainingDate", b =>
                {
                    b.Property<int>("TrainingDateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("TrainingDateID");

                    b.HasIndex("CourseID");

                    b.ToTable("TrainingDate");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Dietary", b =>
                {
                    b.HasOne("AdaptItAcademy.DataAccess.Models.Training", null)
                        .WithMany("Dietaries")
                        .HasForeignKey("TrainingID");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Training", b =>
                {
                    b.HasOne("AdaptItAcademy.DataAccess.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.TrainingDate", b =>
                {
                    b.HasOne("AdaptItAcademy.DataAccess.Models.Course", null)
                        .WithMany("TrainingDates")
                        .HasForeignKey("CourseID");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Course", b =>
                {
                    b.Navigation("TrainingDates");
                });

            modelBuilder.Entity("AdaptItAcademy.DataAccess.Models.Training", b =>
                {
                    b.Navigation("Dietaries");
                });
#pragma warning restore 612, 618
        }
    }
}
