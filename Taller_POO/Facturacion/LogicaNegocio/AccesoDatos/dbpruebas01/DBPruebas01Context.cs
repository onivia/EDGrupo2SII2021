using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LogicaNegocio.AccesoDatos.dbpruebas01
{
    public partial class DBPruebas01Context : DbContext
    {
        public DBPruebas01Context()
        {
        }

        public DBPruebas01Context(DbContextOptions<DBPruebas01Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<NotaCredito> NotaCreditos { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea });

                entity.ToTable("DetalleFactura");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(20)
                    .HasColumnName("numeroFactura");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("precioUnidad");

                entity.Property(e => e.TotalLinea)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("totalLinea");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("Factura");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .HasColumnName("numero");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroOrdenCompra)
                    .HasMaxLength(20)
                    .HasColumnName("numeroOrdenCompra");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("razonSocial");
            });

            modelBuilder.Entity<NotaCredito>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("NotaCredito");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .HasColumnName("numero");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroFactura)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("numeroFactura");
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("OrdenCompra");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .HasColumnName("numero");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroRequisicion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("numeroRequisicion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
