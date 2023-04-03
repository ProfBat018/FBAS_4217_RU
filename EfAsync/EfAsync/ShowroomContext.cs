using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfAsync
{
    public partial class ShowroomContext : DbContext
    {
        public ShowroomContext()
        {
        }

        public ShowroomContext(DbContextOptions<ShowroomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Salesman> Salesmen { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=WAYNE;Initial Catalog=Showroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Make).HasMaxLength(30);

                entity.Property(e => e.Model).HasMaxLength(30);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Customers__Perso__2A4B4B5E");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Surname).HasMaxLength(30);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sales__CarId__33D4B598");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sales__PersonId__34C8D9D1");

                entity.HasOne(d => d.Salesman)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesmanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sales__SalesmanI__32E0915F");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.ToTable("Salesman");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Salesmen)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Salesman__Person__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
