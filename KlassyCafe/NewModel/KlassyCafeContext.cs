using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class KlassyCafeContext : IdentityDbContext<IdentityUser>
    {
        public KlassyCafeContext()
        {
        }

        public KlassyCafeContext(DbContextOptions<KlassyCafeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbEmployee> TbEmployees { get; set; }
        public virtual DbSet<TbInvoice> TbInvoices { get; set; }
        public virtual DbSet<TbItem> TbItems { get; set; }
        public virtual DbSet<TbJop> TbJops { get; set; }
        public virtual DbSet<TbOrder> TbOrders { get; set; }
        public virtual DbSet<TbReservation> TbReservations { get; set; }
        public virtual DbSet<TbSlider> TbSliders { get; set; }
        public virtual DbSet<VwInvDatum> VwInvData { get; set; }
        public virtual DbSet<VwItemCategory> VwItemCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9UFN9IR\\SQLEXPRESS;Database=KlassyCafe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbEmployee>(entity =>
            {
                entity.HasKey(e => e.NationalId);

                entity.ToTable("TbEmployee");

                entity.Property(e => e.NationalId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Cockes).HasMaxLength(50);

                entity.Property(e => e.Facebook).HasMaxLength(500);

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.Insta).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Twitter).HasMaxLength(500);

                entity.HasOne(d => d.Jop)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.JopId)
                    .HasConstraintName("FK_TbEmployee_TbJops");
            });

            modelBuilder.Entity<TbInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Invoice)
                    .WithMany()
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbInvoices_TbOrders");

                entity.HasOne(d => d.Item)
                    .WithMany()
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbInvoices_TbItems");
            });

            modelBuilder.Entity<TbItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                //entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.Disciption).HasMaxLength(200);

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbItems)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_TbItems_TbCategories");
            });

            modelBuilder.Entity<TbJop>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_TbDelevery");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Canceled).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DateTimeNow).HasColumnType("datetime");

                entity.Property(e => e.Delevered).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeleveryDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbReservation>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.ReservationId })
                    .HasName("PK_Reservation");

                entity.ToTable("TbReservation");

                //entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.NGuests).HasColumnName("N_Guests");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TimeSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbSlider>(entity =>
            {
                entity.HasKey(e => e.SliderId);

                entity.ToTable("TbSlider");

                entity.Property(e => e.SliderId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<VwInvDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInvData");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DeleveryDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VwItemCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwItemCategory");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Disciption).HasMaxLength(200);

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 4)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
