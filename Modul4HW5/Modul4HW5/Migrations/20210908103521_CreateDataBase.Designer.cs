﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modul4HW5.DataAccess;

namespace Modul4HW5.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210908103521_CreateDataBase")]
    partial class CreateDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modul4HW5.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            DateOfRegistration = new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(493),
                            FirstName = "Ivan",
                            SecondName = "Budko"
                        },
                        new
                        {
                            ClientId = 2,
                            DateOfRegistration = new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(876),
                            FirstName = "Dmitro",
                            SecondName = "Burunko"
                        },
                        new
                        {
                            ClientId = 3,
                            DataOfBirth = new DateTime(2001, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1198),
                            FirstName = "Yurii",
                            SecondName = "Leonov"
                        },
                        new
                        {
                            ClientId = 4,
                            DataOfBirth = new DateTime(2000, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1215),
                            FirstName = "Andry",
                            SecondName = "Kust"
                        },
                        new
                        {
                            ClientId = 5,
                            DataOfBirth = new DateTime(2014, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfRegistration = new DateTime(2021, 9, 8, 13, 35, 20, 581, DateTimeKind.Local).AddTicks(1218),
                            FirstName = "Misha",
                            SecondName = "Krutoy"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredData")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DataOfBirth = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tatur",
                            HiredData = new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = " ",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            DataOfBirth = new DateTime(1999, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vlad",
                            HiredData = new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Vladov",
                            OfficeId = 2,
                            TitleId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            DataOfBirth = new DateTime(1990, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            HiredData = new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Stepanov",
                            OfficeId = 3,
                            TitleId = 3
                        },
                        new
                        {
                            EmployeeId = 4,
                            DataOfBirth = new DateTime(1954, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mark",
                            HiredData = new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Fedorov",
                            OfficeId = 4,
                            TitleId = 4
                        },
                        new
                        {
                            EmployeeId = 5,
                            DataOfBirth = new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tom",
                            HiredData = new DateTime(2010, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Black",
                            OfficeId = 5,
                            TitleId = 5
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjects");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 557m,
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            ProjectId = 2,
                            Rate = 557m,
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 3,
                            ProjectId = 3,
                            Rate = 100m,
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 4,
                            EmployeeId = 4,
                            ProjectId = 4,
                            Rate = 100m,
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 5,
                            EmployeeId = 5,
                            ProjectId = 5,
                            Rate = 557m,
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "asfafasf",
                            Title = "asaaaswd"
                        },
                        new
                        {
                            OfficeId = 2,
                            Location = "qwert",
                            Title = "lkgfd"
                        },
                        new
                        {
                            OfficeId = 3,
                            Location = "sss",
                            Title = "aaa"
                        },
                        new
                        {
                            OfficeId = 4,
                            Location = "ggg",
                            Title = "sddfg"
                        },
                        new
                        {
                            OfficeId = 5,
                            Location = "hgfgr",
                            Title = "vcbcvb"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedTime")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 12345m,
                            ClientId = 1,
                            Name = "First",
                            StartedTime = new DateTime(2001, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 12345m,
                            ClientId = 2,
                            Name = "Second",
                            StartedTime = new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 12345m,
                            ClientId = 3,
                            Name = "qqq",
                            StartedTime = new DateTime(2001, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 12345m,
                            ClientId = 4,
                            Name = "ddd",
                            StartedTime = new DateTime(2001, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 12345m,
                            ClientId = 5,
                            Name = "dssfs",
                            StartedTime = new DateTime(2021, 9, 8, 13, 35, 20, 574, DateTimeKind.Local).AddTicks(3069)
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TitleId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "qwerty"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "fdsgrs"
                        },
                        new
                        {
                            TitleId = 3,
                            Name = "fdgkjjgf"
                        },
                        new
                        {
                            TitleId = 4,
                            Name = "asdfg"
                        },
                        new
                        {
                            TitleId = 5,
                            Name = "zxcvbn"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Models.Employee", b =>
                {
                    b.HasOne("Modul4HW5.Models.Office", "Office")
                        .WithMany("Employes")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW5.Models.Title", "Title")
                        .WithMany("Employes")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Modul4HW5.Models.EmployeeProject", b =>
                {
                    b.HasOne("Modul4HW5.Models.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW5.Models.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Modul4HW5.Models.Project", b =>
                {
                    b.HasOne("Modul4HW5.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Modul4HW5.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Modul4HW5.Models.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Modul4HW5.Models.Office", b =>
                {
                    b.Navigation("Employes");
                });

            modelBuilder.Entity("Modul4HW5.Models.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Modul4HW5.Models.Title", b =>
                {
                    b.Navigation("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}
