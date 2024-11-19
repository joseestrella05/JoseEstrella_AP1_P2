using JoseEstrella_AP1_p2.DAL;
using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JoseEstrella_AP1_p2.Services;

public class ComboDetalleService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int DetalleId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.ComboDestalles.AllAsync(c => c.DestalleId == DetalleId);

    }

    public async Task<bool> Guardar(ComboDestalle Detalle)
    {
        if (!await Existe(Detalle.DestalleId))
        {
            return await Insertar(Detalle);
        }
        else
        {
            return await Modificar(Detalle);
        }
    }

    public async Task<bool> Insertar(ComboDestalle Detalle)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.ComboDestalles.Add(Detalle);
        return await contexto.SaveChangesAsync() > 0;


    }

    public async Task<bool> Modificar(ComboDestalle Detalle)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(Detalle);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var Detalle = contexto.ComboDestalles.Find(id);
        contexto.ComboDestalles.Remove(Detalle);
        var cantidad = await contexto.SaveChangesAsync();
        return cantidad > 0;
    }

    public async Task<ComboDestalle?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.ComboDestalles.Include(c => c.DestalleId == id)
            .FirstOrDefaultAsync(c => c.DestalleId == id);
    }

    public async Task<List<ComboDestalle>> Listar(Expression<Func<ComboDestalle, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.ComboDestalles.Include(a => a.DestalleId)
           .Where(criterio)
           .AsNoTracking()
           .ToListAsync();


    }
}
