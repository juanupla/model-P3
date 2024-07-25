using Microsoft.EntityFrameworkCore;
using practica0.Data;
using practica0.Model;

namespace practica0.Repositories.Impl;

public class RepoRepositoryImpl : RepoRepository
{
    private readonly ContextBD _context;
    public RepoRepositoryImpl(ContextBD contextBD)
    {
        _context = contextBD;
    }

    public async Task<List<Albanile>> getalbaniles(string idObra)
    {
        Guid id;
        if(!Guid.TryParse(idObra, out id))
        {
            return null;
        }
        var resp = await _context.AlbanilesXObras.Where(c =>c.IdObra ==id).Select(c => c.IdAlbanil).ToListAsync();

        var resp2 = await _context.Albaniles.Where(c => !resp.Contains(c.Id)).ToListAsync();

        return resp2;
    }

    public async Task<List<Obra>> GetObras()
    {
        var obras = await _context.Obras.Include(c => c.AlbanilesXObras).Include(c =>c.IdTipoObraNavigation).ToListAsync();

        return obras;
    }

    public async Task<Albanile> postAlbanile(Albanile albanil)
    {
        albanil.Id = Guid.NewGuid();

        await _context.Albaniles.AddAsync(albanil);
        await _context.SaveChangesAsync();
        return albanil;
    }

    public async Task<AlbanilesXObra> postAlbanileXObra(AlbanilesXObra albaxobra)
    {
        if (albaxobra == null)
        {
            return null;
        }

        albaxobra.Id=Guid.NewGuid();

        await _context.AlbanilesXObras.AddAsync(albaxobra);
        await _context.SaveChangesAsync();

        return albaxobra;
    }
}

