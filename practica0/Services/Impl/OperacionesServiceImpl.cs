using AutoMapper;
using practica0.DTOs;
using practica0.Model;
using practica0.Queries;
using practica0.Repositories;
using practica0.Response;
using System.Net;

namespace practica0.Services.Impl;

public class OperacionesServiceImpl : OperacionesService
{
    private readonly RepoRepository repository;
    private readonly IMapper mapper;
    public OperacionesServiceImpl(RepoRepository repoRepository1, IMapper mapper1) { 
        repository = repoRepository1;
        mapper = mapper1;
    }

    public async Task<ApiResponse<List<AlbanileDto>>> getalbaniles(string idObra)
    {
        var resp = new ApiResponse<List<AlbanileDto>>();

        var respRepo = await repository.getalbaniles(idObra);

        var respMap = mapper.Map<List<AlbanileDto>>(respRepo);

        resp.Data = respMap;
        return resp;
    }

    public async Task<ApiResponse<List<ObrasDto>>> getObras()
    {
        var resp = new ApiResponse<List<ObrasDto>>();

        var repoResp = await repository.GetObras();

        var obrasMap = mapper.Map<List<ObrasDto>>(repoResp);

        for (var i = 0; i < obrasMap.Count; i++) {

            obrasMap[i].cantAlba = repoResp[i].AlbanilesXObras.Count;
        }
        resp.Data = obrasMap;

        return resp;
    }

    public async Task<ApiResponse<AlbanileDto>> postAlbanile(NewAlbanileQuery albanil)
    {
        var resp = new ApiResponse<AlbanileDto>();

        var alba = mapper.Map<Albanile>(albanil);

        var respRepo = repository.postAlbanile(alba);

        if(respRepo == null)
        {
            resp.setError("error al crear alba", HttpStatusCode.BadRequest);
            return resp;
        }
        resp.Data = mapper.Map<AlbanileDto>(respRepo);
        return resp;
    }

    public async Task<ApiResponse<AlbaXObraDto>> postAlbaXObra(AlbaXObraQuerycs albaXObraQuerycs)
    {
        var resp = new ApiResponse<AlbaXObraDto>();

        var alba = mapper.Map<AlbanilesXObra>(albaXObraQuerycs);

        var respRepo = await repository.postAlbanileXObra(alba);


        if (respRepo != null)
        {

            resp.Data = mapper.Map<AlbaXObraDto>(respRepo);
            return resp;
        }
        else { 
            resp.setError("error al  cargar alba",HttpStatusCode.BadRequest);
            return resp;
        }

    }
}

