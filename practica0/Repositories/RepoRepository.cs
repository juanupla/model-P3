using practica0.Model;

namespace practica0.Repositories;

public interface RepoRepository
{
    Task<List<Obra>> GetObras();
    Task<AlbanilesXObra> postAlbanileXObra(AlbanilesXObra obra);
    Task<Albanile>postAlbanile(Albanile albanil);
    Task<List<Albanile>> getalbaniles(string idObra);
}

