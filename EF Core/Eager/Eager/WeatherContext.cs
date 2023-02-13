using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Eager;

public partial class WeatherContext : DbContext
{
    public WeatherContext()
    {
    }

    public WeatherContext(DbContextOptions<WeatherContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cloud> Clouds { get; set; }

    public virtual DbSet<Coord> Coords { get; set; }

    public virtual DbSet<Forecast> Forecasts { get; set; }

    public virtual DbSet<ForecastHistory> ForecastHistories { get; set; }

    public virtual DbSet<Main> Mains { get; set; }

    public virtual DbSet<Sy> Sys { get; set; }

    public virtual DbSet<Weather> Weathers { get; set; }

    public virtual DbSet<Wind> Winds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=WAYNE;Initial Catalog=Weather;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cloud>(entity =>
        {
            entity.HasKey(e => e.CloudsId);

            entity.Property(e => e.All).HasColumnName("all");
        });

        modelBuilder.Entity<Coord>(entity =>
        {
            entity.ToTable("Coord");

            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
        });

        modelBuilder.Entity<Forecast>(entity =>
        {
            entity.HasKey(e => e.ForecastId);

            entity.HasIndex(e => e.CloudsId, "IX_Forecasts_CloudsId");

            entity.HasIndex(e => e.CoordId, "IX_Forecasts_CoordId");

            entity.HasIndex(e => e.MainId, "IX_Forecasts_MainId");

            entity.HasIndex(e => e.SysId, "IX_Forecasts_SysId");

            entity.HasIndex(e => e.WindId, "IX_Forecasts_WindId");

            entity.Property(e => e.Base)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("_base");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Dt).HasColumnName("dt");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.Visibility).HasColumnName("visibility");

            entity.HasOne(d => d.Clouds).WithMany(p => p.Forecasts).HasForeignKey(d => d.CloudsId);

            entity.HasOne(d => d.Coord).WithMany(p => p.Forecasts).HasForeignKey(d => d.CoordId);

            entity.HasOne(d => d.Main).WithMany(p => p.Forecasts).HasForeignKey(d => d.MainId);

            entity.HasOne(d => d.Sys).WithMany(p => p.Forecasts).HasForeignKey(d => d.SysId);

            entity.HasOne(d => d.Wind).WithMany(p => p.Forecasts).HasForeignKey(d => d.WindId);
        });

        modelBuilder.Entity<ForecastHistory>(entity =>
        {
            entity.HasIndex(e => e.ForecastId, "IX_ForecastHistories_ForecastId");

            entity.HasOne(d => d.Forecast).WithMany(p => p.ForecastHistories).HasForeignKey(d => d.ForecastId);
        });

        modelBuilder.Entity<Main>(entity =>
        {
            entity.ToTable("Main");

            entity.Property(e => e.FeelsLike).HasColumnName("feels_like");
            entity.Property(e => e.Humidity).HasColumnName("humidity");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.Temp).HasColumnName("temp");
            entity.Property(e => e.TempMax).HasColumnName("temp_max");
            entity.Property(e => e.TempMin).HasColumnName("temp_min");
        });

        modelBuilder.Entity<Sy>(entity =>
        {
            entity.HasKey(e => e.SysId);

            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sunrise).HasColumnName("sunrise");
            entity.Property(e => e.Sunset).HasColumnName("sunset");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e => e.WeatherId);

            entity.ToTable("Weather");

            entity.HasIndex(e => e.ForecastId, "IX_Weather_ForecastId");

            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Main).HasColumnName("main");

            entity.HasOne(d => d.Forecast).WithMany(p => p.Weathers).HasForeignKey(d => d.ForecastId);
        });

        modelBuilder.Entity<Wind>(entity =>
        {
            entity.ToTable("Wind");

            entity.Property(e => e.Deg).HasColumnName("deg");
            entity.Property(e => e.Speed).HasColumnName("speed");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
