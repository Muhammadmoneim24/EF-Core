﻿// <auto-generated />
using System;
using EFCoreCodefirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreCodefirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231003090018_finalmigration2")]
    partial class finalmigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreCodefirst.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Math",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 3000m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 2500m
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Enrollments", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments", (string)null);

                    b.HasData(
                        new
                        {
                            SectionId = 6,
                            StudentId = 1
                        },
                        new
                        {
                            SectionId = 6,
                            StudentId = 2
                        },
                        new
                        {
                            SectionId = 7,
                            StudentId = 3
                        },
                        new
                        {
                            SectionId = 7,
                            StudentId = 4
                        },
                        new
                        {
                            SectionId = 8,
                            StudentId = 5
                        },
                        new
                        {
                            SectionId = 8,
                            StudentId = 6
                        },
                        new
                        {
                            SectionId = 9,
                            StudentId = 7
                        },
                        new
                        {
                            SectionId = 9,
                            StudentId = 8
                        },
                        new
                        {
                            SectionId = 10,
                            StudentId = 9
                        },
                        new
                        {
                            SectionId = 10,
                            StudentId = 10
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ahmed Ali",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mohamed Ahmed",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Issam Abdelnabi",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Osama Elzero",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mohamed",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "building A",
                            OfficeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "building B",
                            OfficeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Adminstration",
                            OfficeName = "Off_32"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_45"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_4"
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDAy",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Twice-a-Week",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InstructorId = 1,
                            SectionName = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InstructorId = 3,
                            SectionName = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InstructorId = 2,
                            SectionName = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InstructorId = 5,
                            SectionName = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InstructorId = 5,
                            SectionName = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS3"
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.SectionSchedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionSchedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 4,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 5,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 2,
                            SectionId = 6,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 7,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 8,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 9,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 10,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 5,
                            SectionId = 11,
                            StartTime = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .HasMaxLength(55)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .HasMaxLength(55)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Fatima",
                            LName = "Ali"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Noor",
                            LName = "Saleh"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Omar",
                            LName = "Yousef"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Huda",
                            LName = "Ahmed"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Amira",
                            LName = "Tariq"
                        },
                        new
                        {
                            Id = 6,
                            FName = "Zainab",
                            LName = "Ismail"
                        },
                        new
                        {
                            Id = 7,
                            FName = "Yousef",
                            LName = "Farid"
                        },
                        new
                        {
                            Id = 8,
                            FName = "Lila",
                            LName = "Mustafa"
                        },
                        new
                        {
                            Id = 9,
                            FName = "Mohamed",
                            LName = "Adel"
                        },
                        new
                        {
                            Id = 10,
                            FName = "Samir",
                            LName = "Nabil"
                        });
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Enrollments", b =>
                {
                    b.HasOne("EFCoreCodefirst.Entities.Section", "Section")
                        .WithMany("Enrollments")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodefirst.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Instructor", b =>
                {
                    b.HasOne("EFCoreCodefirst.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EFCoreCodefirst.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Section", b =>
                {
                    b.HasOne("EFCoreCodefirst.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodefirst.Entities.Instructor", "Instructor")
                        .WithMany("sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.SectionSchedule", b =>
                {
                    b.HasOne("EFCoreCodefirst.Entities.Schedule", "Schedule")
                        .WithMany("SectionSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodefirst.Entities.Section", "Section")
                        .WithMany("SectionSchedules")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Instructor", b =>
                {
                    b.Navigation("sections");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Office", b =>
                {
                    b.Navigation("Instructor")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Schedule", b =>
                {
                    b.Navigation("SectionSchedules");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Section", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("SectionSchedules");
                });

            modelBuilder.Entity("EFCoreCodefirst.Entities.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
