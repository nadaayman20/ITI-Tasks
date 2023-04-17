using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Task1.Models
{
    public partial class EMPLOYEESContext : DbContext
    {
        public EMPLOYEESContext()
        {
        }

        public EMPLOYEESContext(DbContextOptions<EMPLOYEESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=EMPLOYEES;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("cityID");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId).HasColumnName("countryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.DeptDesc).HasMaxLength(50);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.CtyId).HasColumnName("CtyID");

                entity.Property(e => e.DId).HasColumnName("dID");

                entity.Property(e => e.EmpFname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmpHdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EmpHDate");

                entity.Property(e => e.EmpLname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.DId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Emps_Depts");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
