using JoseEstrella_AP1_p2.DAL;
using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Linq.Expressions;

namespace JoseEstrella_AP1_p2.Services;

public class ArticuloService(IDbContextFactory<Contexto> DbFactory)
{
     public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
     {
         await using var contexto = await DbFactory.CreateDbContextAsync();
         return await contexto.Articulos.Include(a=> a.ArticuloId)
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();


     } 

}
