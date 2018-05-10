using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSIapp
{
    public partial class csidataContext : DbContext
    {
        public csidataContext(DbContextOptions<csidataContext> options) : base(options)
        {
        }
        public virtual DbSet<RequestMetrics> RequestMetrics { get; set; }
        public virtual DbSet<RequestMetricsDetails> RequestMetricsDetails { get; set; }
        public virtual DbSet<RequestMetricsExtDetails> RequestMetricsExtDetails { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite(@"DataSource=csidata.db");
                //optionsBuilder.UseSqlServer(@"Server=tcp:csidatacidm4390.database.windows.net,1433;Initial Catalog=CSIData;Persist Security Info=False;User ID=csiadmin;Password=csiCIDM4390;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestMetrics>(entity =>
            {
                entity.HasKey(e => e.RequestMetricId);

                entity.HasIndex(e => e.SessionId)
                    .HasName("RequestMetrics_Index_SessionID");

                entity.HasIndex(e => new { e.Timestamp, e.BankNumber })
                    .HasName("RequestMetrics_Index_Timestamp_BankNumber");

                entity.HasIndex(e => new { e.Duration, e.Apimethod, e.ResponseCode })
                    .HasName("RequestMetrics_Index_Duration");

                entity.Property(e => e.RequestMetricId).ValueGeneratedNever();

                entity.Property(e => e.Apicontroller)
                    .HasColumnName("APIController")
                    .HasMaxLength(150);

                entity.Property(e => e.Apimethod)
                    .HasColumnName("APIMethod")
                    .HasMaxLength(150);

                entity.Property(e => e.Apiversion)
                    .HasColumnName("APIVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PartnerKey).HasMaxLength(200);

                entity.Property(e => e.ReasonPhrase).HasMaxLength(200);

                entity.Property(e => e.RequestBody).HasMaxLength(4096);

                entity.Property(e => e.RequestCert).HasMaxLength(128);

                entity.Property(e => e.ResponseBody).HasMaxLength(200);

                entity.Property(e => e.ServerName).HasMaxLength(50);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SourceIp)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasColumnName("URI")
                    .HasMaxLength(1848);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Verb)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<RequestMetricsDetails>(entity =>
            {
                entity.HasIndex(e => e.RequestMetricId)
                    .HasName("RequestMetricsDetails_Index_MetricID");

                entity.HasIndex(e => e.RequestMetricsExtId)
                    .HasName("RequestMetricsDetails_Index_MetricExtID");

                entity.Property(e => e.RequestMetricsDetailsId)
                    .HasColumnName("RequestMetricsDetailsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsError).HasColumnType("bit");

                entity.Property(e => e.RequestDetail).HasMaxLength(500);

                entity.Property(e => e.RequestMetricsExtId).HasColumnName("RequestMetricsExtID");

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.HasOne(d => d.RequestMetric)
                    .WithMany(p => p.RequestMetricsDetails)
                    .HasForeignKey(d => d.RequestMetricId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RequestMetricsExtDetails>(entity =>
            {
                entity.HasKey(e => e.RequestMetricsExtId);

                entity.Property(e => e.RequestMetricsExtId)
                    .HasColumnName("RequestMetricsExtID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RequestDetail).IsUnicode(false);

                entity.Property(e => e.ResponseDetail).IsUnicode(false);
            });
        }
    }
}
