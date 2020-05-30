using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vignette.Data.Model;

namespace Vignette.Data
{
    public class VignetteContext : DbContext
    {

        public VignetteContext()
        {

        }
        public VignetteContext(DbContextOptions options)
            : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Vignettes> Vignettes { get; set; }
        public virtual DbSet<BoughtVignette> BoughtVignettes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
