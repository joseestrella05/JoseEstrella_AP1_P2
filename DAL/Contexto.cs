using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;

namespace JoseEstrella_AP1_p2.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Combos> Combos { get; set; }
    public DbSet<ComboDestalle> ComboDestalles { get; set; }
    public DbSet<Articulos> Articulos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Articulos>().HasData(new List<Articulos>()
        {
            new () {ArticuloId = 1, Descripcion = "Computadora",
                Costo = 20000, Precio = 35000, Existencia = 50},

        });
    }
}
