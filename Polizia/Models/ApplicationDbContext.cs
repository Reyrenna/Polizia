using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Polizia.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anagrafica> Anagraficas { get; set; }

    public virtual DbSet<TipoViolazione> TipoViolaziones { get; set; }

    public virtual DbSet<Verbale> Verbales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=pc_di_Rey\\SQLEXPRESS;Database=poliziaaaaa;User Id=sa;Password=sa; TrustServerCertificate=true ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anagrafica>(entity =>
        {
            entity.HasKey(e => e.IdAnagrafica).HasName("PK__Anagrafi__11B12B19CB54AE6A");

            entity.Property(e => e.CodFisc).IsFixedLength();
        });

        modelBuilder.Entity<TipoViolazione>(entity =>
        {
            entity.HasKey(e => e.IdViolazione).HasName("PK__TipoViol__30BEFB3BBBD539E0");
        });

        modelBuilder.Entity<Verbale>(entity =>
        {
            entity.HasKey(e => e.IdVerbale).HasName("PK__Verbale__471AC560F7A50EEF");

            entity.HasOne(d => d.IdAnagraficaNavigation).WithMany(p => p.Verbales).HasConstraintName("FK_IdPersona");

            entity.HasOne(d => d.IdViolazioneNavigation).WithMany(p => p.Verbales).HasConstraintName("FK_IdInfrazione");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
