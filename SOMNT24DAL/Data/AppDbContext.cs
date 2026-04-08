using Microsoft.EntityFrameworkCore;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ReturnType> ReturnTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnType>(entity =>
            {
                entity.HasKey(e => e.RetnType); 

                entity.Property(e => e.BusinessUnit).HasMaxLength(50);
                entity.Property(e => e.ModuleCode).HasMaxLength(50);
                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TimeStamp)
                      .IsRowVersion(); 
            });
        }
    }
}
