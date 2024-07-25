using practica0.DTOs;
using practica0.Model;
using practica0.Queries;
using practica0.Response;

namespace practica0.Services;

public interface OperacionesService
{
    Task<ApiResponse<List<ObrasDto>>> getObras();
    Task<ApiResponse<AlbaXObraDto>> postAlbaXObra(AlbaXObraQuerycs albaXObraQuerycs);
    Task<ApiResponse<AlbanileDto>> postAlbanile(NewAlbanileQuery albanil);
    Task<ApiResponse<List<AlbanileDto>>> getalbaniles(string idObra);
}

