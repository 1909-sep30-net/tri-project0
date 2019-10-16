using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Entities
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
                    .HasName("PK__Customer__C1F8DC597FE035A7");

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

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasKey(e => new { e.Oid, e.Pid })
                    .HasName("CompKey_OP");

                entity.ToTable("Customer_Order");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.O)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer_Or__OID__03F0984C");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer_Or__PID__04E4BC85");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => new { e.Lid, e.Pid })
                    .HasName("CompKey_LP");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.InventoryNavigation)
                    .HasForeignKey(d => d.Lid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__LID__0A9D95DB");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__PID__0B91BA14");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PK__Location__C6555721C3D79294");

                entity.Property(e => e.Lid)
                    .HasColumnName("LID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Located)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__Orders__CB394B396E3801BE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Lid).HasColumnName("LID");

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
                    .HasConstraintName("FK__Orders__CID__7E37BEF6");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Lid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__LID__7F2BE32F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C5775520C99B98DC");

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
