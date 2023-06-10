using ICEBERG.Dominio;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ICEBERG.Datos
{
    public partial class Iceberg : DbContext
    {
        public Iceberg()
            : base("name=Iceberg")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        //public virtual DbSet<Empledo> Empleado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombres)
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.TelefonoFijo);
            //.IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Celular);
                //.IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);
        }
    }
}
