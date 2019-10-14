using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WatchStore.Entities
{
    public partial class WatchStoreContext : DbContext
    {
        public WatchStoreContext()
        {
        }

        public WatchStoreContext(DbContextOptions<WatchStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrder { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Customer__C1F8DC593EEF970D");

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addresses)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Order");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.O)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer_Or__OID__6B24EA82");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer_Or__PID__6C190EBB");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Located)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.LocatedNavigation)
                    .WithMany(p => p.InventoryNavigation)
                    .HasForeignKey(d => d.Located)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Locat__70DDC3D8");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__PID__71D1E811");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.Located)
                    .HasName("PK__Location__2055A52C417B00D7");

                entity.HasIndex(e => e.Lid)
                    .HasName("UQ__Location__C65557204875CC31")
                    .IsUnique();

                entity.Property(e => e.Located)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lid).HasColumnName("LID");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__Orders__CB394B3950695D2A");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("Order_Time")
                    .HasColumnType("date");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("Order_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__CID__6754599E");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C57755202C87B0B4");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
