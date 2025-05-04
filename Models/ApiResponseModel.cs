namespace TaskApiRest.Models;

public class ApiResponseModel<T>
{
    public T Data { get; set; }
    public string Mensaje { get; set; }
    public int StatusCode { get; set; }

    public ApiResponseModel(T data, string mensaje, int statusCode)
    {
        Data = data;
        Mensaje = mensaje;
        StatusCode = statusCode;
    }
}