using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Hotel_Mangement_System.Entitiess;

namespace Hotel_Mangement_System.Contexts
{
    public partial class FrontEndContext : DbContext
    {
        public virtual DbSet<reservation> reservations { get; set; }

        public FrontEndContext()
        {
        }

        public FrontEndContext(DbContextOptions<FrontEndContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FRONTEND_RESERVATION;Integrated Security=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<reservation>(entity =>
            {
                entity.Property(e => e.card_cvc).IsFixedLength();

                entity.Property(e => e.card_type).IsFixedLength();

                entity.Property(e => e.payment_type).IsFixedLength();

                entity.Property(e => e.room_floor).IsFixedLength();

                entity.Property(e => e.room_number).IsFixedLength();

                entity.Property(e => e.room_type).IsFixedLength();

                entity.Property(e => e.zip_code).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
