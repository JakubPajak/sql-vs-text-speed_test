using Microsoft.EntityFrameworkCore;
using PDB_SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<BasicDataDto> basicDataDtos {  get; set; }

        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=jakubpajak_asus;Database=pdb_database;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicDataDto>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                .IsRequired();

                entity.Property(e => e.Surname)
                .IsRequired();

                entity.Property(e => e.Phone)
                .IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
