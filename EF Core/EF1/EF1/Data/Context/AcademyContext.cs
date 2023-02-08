using System;
using System.Collections.Generic;
using EF1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF1.Data.Context;

public partial class AcademyContext : DbContext
{
    public AcademyContext()
    {
    }


    public virtual DbSet<Curator> Curators { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupsCurator> GroupsCurators { get; set; }

    public virtual DbSet<GroupsLecture> GroupsLectures { get; set; }

    public virtual DbSet<Lecture> Lectures { get; set; }

    public virtual DbSet<NewPerson> NewPeople { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ConfigurationBuilder builder = new();

        builder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();

        var connectionString = config.GetConnectionString("Academy");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // FluentAPI
    {
        modelBuilder.Entity<Curator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curators__3214EC07B63A25F9");

            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Surname).HasMaxLength(30);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC0791DE8EA9");

            entity.Property(e => e.Financing).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(30);

            entity.HasOne(d => d.Faculty).WithMany(p => p.Departments)
                .HasForeignKey(d => d.FacultyId)
                .HasConstraintName("FK__Departmen__Facul__35BCFE0A");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07E78F6E19");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facultie__3214EC07060B9C48");

            entity.Property(e => e.Financing).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Groups__3214EC074C5A4765");

            entity.Property(e => e.Name).HasMaxLength(30);

            entity.HasOne(d => d.Department).WithMany(p => p.Groups)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Groups__Departme__3A81B327");
        });

        modelBuilder.Entity<GroupsCurator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupsCu__3214EC07930D5CAD");

            entity.HasOne(d => d.Curator).WithMany(p => p.GroupsCurators)
                .HasForeignKey(d => d.CuratorId)
                .HasConstraintName("FK__GroupsCur__Curat__3D5E1FD2");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsCurators)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupsCur__Group__3E52440B");
        });

        modelBuilder.Entity<GroupsLecture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupsLe__3214EC07A5F80C74");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsLectures)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupsLec__Group__46E78A0C");

            entity.HasOne(d => d.Lecture).WithMany(p => p.GroupsLectures)
                .HasForeignKey(d => d.LectureId)
                .HasConstraintName("FK__GroupsLec__Lectu__47DBAE45");
        });

        modelBuilder.Entity<Lecture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lectures__3214EC07F55EF136");

            entity.HasIndex(e => e.LectureRoom, "UQ__Lectures__7D5592BBB0D966EA").IsUnique();

            entity.Property(e => e.LectureRoom).HasMaxLength(15);

            entity.HasOne(d => d.Subject).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__Lectures__Subjec__4316F928");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK__Lectures__Teache__440B1D61");
        });

        modelBuilder.Entity<NewPerson>(entity =>
        {
            entity.ToTable("NewPerson");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Person");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subjects__3214EC07510ACC17");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3214EC0702CD173E");

            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Salary).HasColumnType("smallmoney");
            entity.Property(e => e.Surname).HasMaxLength(30);
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Test__3213E83F548A0203");

            entity.ToTable("Test");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
