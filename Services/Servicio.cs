using JoseEstrella_AP1_p2.DAL;
using JoseEstrella_AP1_p2.Models;
using Microsoft.EntityFrameworkCore;

namespace JoseEstrella_AP1_p2.Services;

public class Servicio(IDbContextFactory<Contexto> DbFactory)
{
    /*
     * public async Task<bool> Existe(int Id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }

    public async Task<bool> Guardar()
    {
        
    }

    public async Task<bool> Insertar()
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }

    public async Task<bool> Modificar()
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }

    public async Task<Registro?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }

    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        
    }
    */
}
