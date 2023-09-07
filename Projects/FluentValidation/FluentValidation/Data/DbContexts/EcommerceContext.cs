using FluentValidationExample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationExample.Data.DbContexts
{
    public class EcommerceContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EcommerceContext(DbContextOptions options) : base(options)
        {

        }


        // FluentApi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userEntity = modelBuilder.Entity<User>();

            userEntity.HasKey(u => u.Id);
            userEntity.Property(u => u.Name).IsRequired().HasMaxLength(50);
            userEntity.Property(u => u.Email).IsRequired().HasMaxLength(50);
            userEntity.Property(u => u.Password).IsRequired().HasMaxLength(50);


            base.OnModelCreating(modelBuilder);
        }
    }
}
