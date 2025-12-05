
using Atrium12.Web.Middlewares;

namespace Atrium12.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddProgramDependencies();
            builder.Services.AddHostedService<LoggingBackgroundService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Atrium12"));
            }

            app.MapGet("health", async (ILogger<Program> logger, HttpContext context) =>
            {
                var user = context?.User;
                var ipAddress = context?.Connection?.RemoteIpAddress?.ToString();

                logger.LogInformation(
                    "HealthCheck request from {Username} ({IpAddress})",
                    user?.Identity?.Name,
                    ipAddress
                );

                return Results.Ok(new
                {
                    status = "Healthy",
                    details = new
                    {
                        user = user?.Identity?.Name,
                        ipAddress = ipAddress,
                        database = "Healthy",
                        cache = "Healthy",
                        otherService = "Healthy",
                    },
                });
            });

            app.MapGet("data", async (ILogger<Program> logger, CancellationToken cancellationToken) =>
            {
                logger.LogInformation("Метод начал выполнение");
                try
                {
                    await Task.Delay(10000, cancellationToken);
                }
                catch (Exception)
                {
                    logger.LogInformation("Метод закончил выполнение с прерыванием.");
                }


                logger.LogInformation("Метод закончил выполнение");
            });

            app.MapControllers();

            app.Run();
        }
    }
}
