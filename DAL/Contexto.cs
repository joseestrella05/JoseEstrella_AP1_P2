using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace JoseEstrella_AP1_p2.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Combo> Combos { get; set; }
    public DbSet<ComboDetalles> ComboDetalles { get; set; }
    public DbSet<Producto> Productos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Producto>().HasData(new List<Producto>() {

        new Producto() {ProductoId = 20, Descripcion = "Bocina",
            Costo = 30, Precio = 40,Existencia = 20},
        new Producto() {ProductoId = 50, Descripcion = "Memoria RAM",
            Costo = 100, Precio = 150, Existencia = 10 },
        new Producto() {ProductoId = 60, Descripcion = "Disco duro grafica",
            Costo = 80, Precio = 130, Existencia = 12},
        new Producto() {ProductoId = 70, Descripcion = "Pantalla",
            Costo = 30, Precio = 40,Existencia = 20}
        });

    }
}
