using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FE.Models.zprosansetup;

public partial class ZprosansetupContext : DbContext
{
    public ZprosansetupContext()
    {
    }

    public ZprosansetupContext(DbContextOptions<ZprosansetupContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Setup> Setups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLE2019;Database=zprosansetup; user=sa;Password=sa; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_BIN");

        modelBuilder.Entity<Setup>(entity =>
        {
            entity.ToTable("Setup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Correoenviafac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correoenviafac");
            entity.Property(e => e.Host)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Puerto).HasColumnName("puerto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
