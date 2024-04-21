using Quartz;

namespace QuartzExample.BackgroundJobs
{
    [DisallowConcurrentExecution]
    public class LoggingJob : IJob
    {
        private readonly ILogger<LoggingJob> _logger;
        public LoggingJob(ILogger<LoggingJob> logger)
        { 
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        { 
            _logger.LogInformation($"logging job executed at {DateTime.Now}");
            return Task.CompletedTask;
        }
    }
}
