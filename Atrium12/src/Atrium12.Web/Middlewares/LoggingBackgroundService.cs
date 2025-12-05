namespace Atrium12.Web.Middlewares
{
    public class LoggingBackgroundService : BackgroundService
    {
        private readonly ILogger<LoggingBackgroundService> _logger;

        public LoggingBackgroundService(ILogger<LoggingBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Запись в лог: {time}", DateTime.Now);
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}
