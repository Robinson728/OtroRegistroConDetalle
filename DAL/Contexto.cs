using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OtroRegistroConDetalle.Entidades;

namespace OtroRegistroConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Gestionregistro.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                    new Permisos() { PermisoId = 1, Nombre = "Descuenta", Descripcion = "Se  hace un descuento de 10% al cliente" },
                    new Permisos() { PermisoId = 2, Nombre = "Vende", Descripcion = "Se le puede realizar una venta al cliente" },
                    new Permisos() { PermisoId = 3, Nombre = "Compra", Descripcion = "El cliente puede realizar una compra" }
                );

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios()
                {
                    UsuarioId = 1,
                    Alias = "El negro",
                    Nombre = "Robinson Sarante",
                    Clave = "e3a8d8bcbdad09b078856ef5ad3e6d7172303675ed250ac091ccd3483f68c961",//sarante
                    ConfirmarClave = "e3a8d8bcbdad09b078856ef5ad3e6d7172303675ed250ac091ccd3483f68c961",
                    Activo = true,
                    Rol = "Administrador",
                    Email = "robinsonsarante1234@gmail.com",
                    FechaIngreso = DateTime.Now
                }
            );
        }
    }
}
