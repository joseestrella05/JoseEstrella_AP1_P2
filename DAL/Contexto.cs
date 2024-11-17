using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;

namespace JoseEstrella_AP1_p2.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Registro> Registros { get; set; }
}
