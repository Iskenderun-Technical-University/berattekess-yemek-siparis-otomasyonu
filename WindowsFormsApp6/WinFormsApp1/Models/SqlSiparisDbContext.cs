using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class SqlSiparisDbContext : DbContext
{
    public SqlSiparisDbContext()
    {
    }

    public SqlSiparisDbContext(DbContextOptions<SqlSiparisDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Drink> Drinks { get; set; }

    public virtual DbSet<Siparisler> Siparislers { get; set; }

    public virtual DbSet<UrunType> UrunTypes { get; set; }

    public virtual DbSet<Urunler> Urunlers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SqlSiparisDb;User Id=onur;Password=123456;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Icecekler");

            entity.ToTable("Drink");

            entity.Property(e => e.Fiyati).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Name).HasMaxLength(50);
         
        });

        modelBuilder.Entity<Siparisler>(entity =>
        {
            entity.ToTable("Siparisler");

            entity.Property(e => e.Eposta).HasMaxLength(50);
            entity.Property(e => e.MusteriAd).HasMaxLength(50);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<UrunType>(entity =>
        {
            entity.ToTable("UrunType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UrunTipi).HasMaxLength(50);
        });

        modelBuilder.Entity<Urunler>(entity =>
        {
            entity.ToTable("Urunler");

            entity.Property(e => e.UrunFiyati).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User");

            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.User1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
