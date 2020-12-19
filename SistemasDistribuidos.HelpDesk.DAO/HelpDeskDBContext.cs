using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public partial class HelpDeskDBContext : DbContext
    {
        public HelpDeskDBContext()
        {
        }

        public HelpDeskDBContext(DbContextOptions<HelpDeskDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Incidencia> Incidencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PE-IT000282\\NALDOSERVER;Database=HelpDeskDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasKey(e => e.IdIncidencia);

                entity.Property(e => e.CheckTermino)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstaActivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAnulacion).HasColumnType("date");

                entity.Property(e => e.FechaAtencion).HasColumnType("date");

                entity.Property(e => e.FechaPendiente).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.NivelMovimiento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
