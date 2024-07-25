using System.Net;

namespace practica0.Response;

public class ApiResponse<T>
{
    public T Data { get; set; }
    public bool Success { get; set; }
    public string ErrorMessage { get; set; }
    public HttpStatusCode StatusCode { get; set; }

    public ApiResponse()
    {
        Success = true;
        StatusCode = HttpStatusCode.OK;
        ErrorMessage = "";
    }
    public void setError(string errorMessage,HttpStatusCode statusCode){
        Success = false;
        StatusCode = statusCode;
        ErrorMessage = errorMessage;
    }
}

