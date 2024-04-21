using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace QuartzExample.BackgroundJobs
{
    public static class DependencyInjection
    {
        public static void AddBackgroundJobs(this IServiceCollection services)
        {
            services.AddSingleton<IJobFactory, SingletonJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            services.AddHostedService<QuartzHostedService>();
            services.AddSingleton<LoggingJob>();
            services.AddSingleton(new JobSchedule(
                jobType:typeof(LoggingJob),
                cronExpression:"*/2 * * ? * *"));
        }
    }
}
