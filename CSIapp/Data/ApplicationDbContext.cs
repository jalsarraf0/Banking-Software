using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSIapp.Models;
using CSILibrary;

namespace CSIapp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<RequestMetrics> RequestMetrics {get; set;}
        public DbSet<RequestMetricsDetails> RequestMetricsDetails {get; set;}
        public DbSet<RequestMetricsExtDetails> RequestMetricsExtDetails {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RequestMetrics>().ToTable("RequestMetrics");
            builder.Entity<RequestMetricsDetails>().ToTable("RequestMetricsDetails");
            builder.Entity<RequestMetricsExtDetails>().ToTable("RequestMetricsExtDetails");
        }
    }
}
