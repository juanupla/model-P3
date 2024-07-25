using AutoMapper;
using practica0.DTOs;
using practica0.Model;
using practica0.Queries;

namespace practica0.Mappings;
public class MapperClass : Profile
{
    public MapperClass() {

        CreateMap<ObrasDto, Obra>();
        CreateMap<Obra,ObrasDto>();
        CreateMap<TiposObra,TiposObraDto>();
        CreateMap<TiposObraDto,TiposObra>();

        CreateMap<AlbaXObraQuerycs, AlbanilesXObra>();
        CreateMap<AlbanilesXObra, AlbaXObraQuerycs>();
        CreateMap<AlbaXObraDto, AlbanilesXObra>();
        CreateMap<AlbanilesXObra, AlbaXObraDto>();

        CreateMap<Albanile, AlbanileDto>();
        CreateMap<AlbanileDto, Albanile>();

    }
}



