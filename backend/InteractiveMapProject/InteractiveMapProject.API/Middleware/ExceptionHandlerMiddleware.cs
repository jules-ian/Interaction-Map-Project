namespace InteractiveMapProject.API.Middleware;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await OnException(context, ex);
        }
    }

    public async Task OnException(HttpContext context, Exception ex)
    {
    }
}

