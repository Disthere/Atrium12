namespace Atrium12.Web.Middlewares
{
    public class ExeptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExeptionMiddleware> _logger;

        public ExeptionMiddleware(RequestDelegate next, ILogger<ExeptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExeptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExeptionAsync(HttpContext context, Exception exeption)
        {
            _logger.LogError(exeption, exeption.Message);

            var (code, errors) = exeption switch
            {
                BadHttpRequestException => (
                StatusCodes.Status500InternalServerError, exeption.Message),
            };

        }
    }
}
