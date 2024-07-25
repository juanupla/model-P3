using Microsoft.AspNetCore.Mvc;
using practica0.DTOs;
using practica0.Queries;
using practica0.Response;
using practica0.Services;

namespace practica0.Controllers;

[ApiController]
public class UnicoController : ControllerBase
{
    private readonly OperacionesService _operacionesService;
    public UnicoController(OperacionesService operacionesService1) { 
    
        _operacionesService = operacionesService1;
    }


    [HttpGet("/getObras")]
    public Task<ApiResponse<List<ObrasDto>>> getObras()
    {
        return _operacionesService.getObras();
    }

    [HttpPost("/postAlbaXObra")]
    public Task<ApiResponse<AlbaXObraDto>> postAlbaXObra([FromBody] AlbaXObraQuerycs albaXObraQuerycs) { 
    
        return _operacionesService.postAlbaXObra(albaXObraQuerycs);
    }

    [HttpGet("/getAlbaniles")]
    public Task<ApiResponse<List<AlbanileDto>>> getAlbaniles(string idObra)
    {
        return _operacionesService.getalbaniles(idObra);
    }

    [HttpPost("/postAlbanil")]
    public Task<ApiResponse<AlbanileDto>> postAlbanil([FromBody] NewAlbanileQuery albanil)
    {

        return _operacionesService.postAlbanile(albanil);
    }
}



