using DbbForTurboAz.Model;
using Microsoft.EntityFrameworkCore;

public class TurboDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<ShowRoom> ShowRooms { get; set; }
    public DbSet<BodyType> BodyTypes { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<WheelDriveType> WheelDriveTypes { get; set; }
    public DbSet<FuelType> FuelTypes { get; set; }
    public DbSet<TransmissionType> TransmissionTypes { get; set; }

    
    // create a constructor with configuration in ef core context 

    public TurboDbContext(DbContextOptions<TurboDbContext> options)
        : base(options)
    {
    }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Make).IsRequired();
            entity.Property(x => x.Model).IsRequired();
            entity.Property(x => x.ProductionDate).IsRequired();
            entity.Property(x => x.VIN).IsRequired();
            entity.Property(x => x.Mileage).IsRequired();
            entity.Property(x => x.EngineVolume).IsRequired();
            entity.Property(x => x.HorsePower).IsRequired();
            entity.Property(x => x.PassengerCount).IsRequired();
            entity.Property(x => x.Price).IsRequired();
            entity.Property(x => x.PhoneNumber).IsRequired();

            entity.HasOne(x => x.ShowRoom)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.ShowRoomId);

            entity.HasOne(x => x.BodyType)
                .WithMany()
                .HasForeignKey(x => x.BodyTypeId);

            entity.HasOne(x => x.City)
                .WithMany()
                .HasForeignKey(x => x.CityId);

            entity.HasOne(x => x.WheelDriveType)
                .WithMany()
                .HasForeignKey(x => x.WheelDriveTypeId);


            entity.HasOne(x => x.FuelType)
                .WithMany()
                .HasForeignKey(x => x.FuelTypeId);

            entity.HasOne(x => x.TransmissionType)
                .WithMany()
                .HasForeignKey(x => x.TransmissionTypeId);
        });

        modelBuilder.Entity<ShowRoom>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
            entity.Property(x => x.Address).IsRequired();
            entity.Property(x => x.PhoneNumber).IsRequired();
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });
        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });

        modelBuilder.Entity<WheelDriveType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });

        modelBuilder.Entity<TransmissionType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });
        base.OnModelCreating(modelBuilder);
    }
}