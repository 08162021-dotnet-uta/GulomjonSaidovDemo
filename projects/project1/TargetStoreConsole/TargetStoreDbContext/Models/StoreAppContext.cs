using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TargetStoreDbContext.Models
{
    public partial class StoreAppContext : DbContext
    {
        public StoreAppContext()
        {
        }

        public StoreAppContext(DbContextOptions<StoreAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ItemizedOrder> ItemizedOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StoreApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemizedOrder>(entity =>
            {
                entity.HasKey(e => e.ItemizedId)
                    .HasName("PK__Itemized__AB3A49C5C62CC4EE");

                entity.Property(e => e.ItemizedId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemizedOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__ItemizedO__Custo__3D5E1FD2");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ItemizedOrders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ItemizedO__Produ__3E52440B");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ItemizedOrders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__ItemizedO__Store__3F466844");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
