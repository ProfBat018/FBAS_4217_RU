﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weather.Data.DbContexts;

#nullable disable

namespace Weather.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    [Migration("20230206130255_WeatherArraychanged")]
    partial class WeatherArraychanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Weather.Data.Models.Clouds", b =>
                {
                    b.Property<int>("CloudsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CloudsId"));

                    b.Property<int>("all")
                        .HasColumnType("int");

                    b.HasKey("CloudsId");

                    b.ToTable("Clouds");
                });

            modelBuilder.Entity("Weather.Data.Models.Coord", b =>
                {
                    b.Property<int>("CoordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoordId"));

                    b.Property<float>("lat")
                        .HasColumnType("real");

                    b.Property<float>("lon")
                        .HasColumnType("real");

                    b.HasKey("CoordId");

                    b.ToTable("Coord");
                });

            modelBuilder.Entity("Weather.Data.Models.Forecast", b =>
                {
                    b.Property<int>("ForecastId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForecastId"));

                    b.Property<int>("CloudsId")
                        .HasColumnType("int");

                    b.Property<int>("CoordId")
                        .HasColumnType("int");

                    b.Property<int>("MainId")
                        .HasColumnType("int");

                    b.Property<int>("SysId")
                        .HasColumnType("int");

                    b.Property<int>("WindId")
                        .HasColumnType("int");

                    b.Property<string>("_base")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cod")
                        .HasColumnType("int");

                    b.Property<int>("dt")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("timezone")
                        .HasColumnType("int");

                    b.Property<int>("visibility")
                        .HasColumnType("int");

                    b.HasKey("ForecastId");

                    b.HasIndex("CloudsId");

                    b.HasIndex("CoordId");

                    b.HasIndex("MainId");

                    b.HasIndex("SysId");

                    b.HasIndex("WindId");

                    b.ToTable("Forecasts");
                });

            modelBuilder.Entity("Weather.Data.Models.ForecastHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ForecastId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SearchTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ForecastId");

                    b.ToTable("ForecastHistories");
                });

            modelBuilder.Entity("Weather.Data.Models.Main", b =>
                {
                    b.Property<int>("MainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainId"));

                    b.Property<float>("feels_like")
                        .HasColumnType("real");

                    b.Property<int>("humidity")
                        .HasColumnType("int");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.Property<float>("temp")
                        .HasColumnType("real");

                    b.Property<float>("temp_max")
                        .HasColumnType("real");

                    b.Property<float>("temp_min")
                        .HasColumnType("real");

                    b.HasKey("MainId");

                    b.ToTable("Main");
                });

            modelBuilder.Entity("Weather.Data.Models.Sys", b =>
                {
                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SysId"));

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("sunrise")
                        .HasColumnType("int");

                    b.Property<int>("sunset")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("SysId");

                    b.ToTable("Sys");
                });

            modelBuilder.Entity("Weather.Data.Models.Weather", b =>
                {
                    b.Property<int>("WeatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeatherId"));

                    b.Property<int>("ForecastId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("main")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeatherId");

                    b.HasIndex("ForecastId");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("Weather.Data.Models.Wind", b =>
                {
                    b.Property<int>("WindId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WindId"));

                    b.Property<int>("deg")
                        .HasColumnType("int");

                    b.Property<float>("speed")
                        .HasColumnType("real");

                    b.HasKey("WindId");

                    b.ToTable("Wind");
                });

            modelBuilder.Entity("Weather.Data.Models.Forecast", b =>
                {
                    b.HasOne("Weather.Data.Models.Clouds", "clouds")
                        .WithMany()
                        .HasForeignKey("CloudsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Data.Models.Coord", "coord")
                        .WithMany()
                        .HasForeignKey("CoordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Data.Models.Main", "main")
                        .WithMany()
                        .HasForeignKey("MainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Data.Models.Sys", "sys")
                        .WithMany()
                        .HasForeignKey("SysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Data.Models.Wind", "wind")
                        .WithMany()
                        .HasForeignKey("WindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clouds");

                    b.Navigation("coord");

                    b.Navigation("main");

                    b.Navigation("sys");

                    b.Navigation("wind");
                });

            modelBuilder.Entity("Weather.Data.Models.ForecastHistory", b =>
                {
                    b.HasOne("Weather.Data.Models.Forecast", "Forecast")
                        .WithMany()
                        .HasForeignKey("ForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forecast");
                });

            modelBuilder.Entity("Weather.Data.Models.Weather", b =>
                {
                    b.HasOne("Weather.Data.Models.Forecast", "Forecast")
                        .WithMany("Weathers")
                        .HasForeignKey("ForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forecast");
                });

            modelBuilder.Entity("Weather.Data.Models.Forecast", b =>
                {
                    b.Navigation("Weathers");
                });
#pragma warning restore 612, 618
        }
    }
}
