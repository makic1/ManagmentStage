﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StageManagment;

#nullable disable

namespace StageManagment.Migrations
{
    [DbContext(typeof(DbContextStageManagment))]
    [Migration("20240916123904_New CAtegorie migration")]
    partial class NewCAtegoriemigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StageManagment.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccountId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            HashPassword = "$2a$11$QRZUo4WXogavhwhfTbXA2O5Xjsa0LE1VaPYptod2RuBPjhn/xP/p.",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("StageManagment.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<int>("ArtistCategorie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            ArtistCategorie = 1,
                            Name = "Bushido"
                        });
                });

            modelBuilder.Entity("StageManagment.Entities.Performance", b =>
                {
                    b.Property<int>("PerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerformanceId"));

                    b.Property<DateTime>("EndPerformance")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("ProgramStageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartPerformance")
                        .HasColumnType("datetime2");

                    b.HasKey("PerformanceId");

                    b.HasIndex("ProgramStageId");

                    b.ToTable("Performances");

                    b.HasData(
                        new
                        {
                            PerformanceId = 1,
                            EndPerformance = new DateTime(2024, 9, 16, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Teil1",
                            ProgramStageId = 1,
                            StartPerformance = new DateTime(2024, 9, 16, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StageManagment.Entities.ProgramStage", b =>
                {
                    b.Property<int>("ProgramStageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramStageId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<long>("DurationInMinutes")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("EndPriceInEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("IsPayd")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("PriceInEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("StartPriceInEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProgramStageId");

                    b.HasIndex("ArtistId");

                    b.ToTable("ProgramStages");

                    b.HasData(
                        new
                        {
                            ProgramStageId = 1,
                            ArtistId = 1,
                            DurationInMinutes = 150L,
                            EndPriceInEuro = 100m,
                            IsPayd = true,
                            Name = "Junge berliner",
                            PriceInEuro = 100m,
                            StartPriceInEuro = 0m
                        });
                });

            modelBuilder.Entity("StageManagment.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<string>("CustomerAddress")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("CustomerCategorie")
                        .HasColumnType("int");

                    b.Property<string>("CustomerCountry")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("CustomerFirstname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerLastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CustomerPLZ")
                        .HasColumnType("int");

                    b.Property<decimal?>("PaydPriceInEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("PerformanceId")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceInEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatRow")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("PerformanceId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            CustomerAddress = "Hohenesmeserstarsse 12",
                            CustomerCategorie = 1,
                            CustomerCountry = "Hohenems",
                            CustomerFirstname = "Mert",
                            CustomerLastname = "Can",
                            CustomerPLZ = 8454,
                            PaydPriceInEuro = 50m,
                            PerformanceId = 1,
                            PriceInEuro = 50m,
                            SeatNumber = 1,
                            SeatRow = 0
                        });
                });

            modelBuilder.Entity("StageManagment.Entities.Performance", b =>
                {
                    b.HasOne("StageManagment.Entities.ProgramStage", "ProgramStage")
                        .WithMany("Performances")
                        .HasForeignKey("ProgramStageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramStage");
                });

            modelBuilder.Entity("StageManagment.Entities.ProgramStage", b =>
                {
                    b.HasOne("StageManagment.Entities.Artist", "Artist")
                        .WithMany("ProgramStages")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("StageManagment.Entities.Ticket", b =>
                {
                    b.HasOne("StageManagment.Entities.Performance", "Performance")
                        .WithMany("Tickets")
                        .HasForeignKey("PerformanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performance");
                });

            modelBuilder.Entity("StageManagment.Entities.Artist", b =>
                {
                    b.Navigation("ProgramStages");
                });

            modelBuilder.Entity("StageManagment.Entities.Performance", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("StageManagment.Entities.ProgramStage", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
