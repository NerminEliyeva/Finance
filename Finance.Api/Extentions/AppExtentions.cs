using Serilog;
using System.Diagnostics;

namespace Finance.Api.Extentions
{
    public static class AppExtentions
    {
        public static void AddMyLogger(this ILoggingBuilder logging, WebApplicationBuilder builder)
        {
            #region 
            // Hrded code loglevel
            //builder.Logging.AddFilter<ConsoleLoggerProvider>("Microsoft", LogLevel.Warning);

            //// Hard Codded
            //var hardCodedLogger = new LoggerConfiguration()
            //    .MinimumLevel.Information()
            //    .MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Warning)
            //    .MinimumLevel.Override("System", Serilog.Events.LogEventLevel.Warning)
            //    .WriteTo.Console()
            //    .WriteTo.File(path: "./DemoApilog-.txt", rollingInterval: RollingInterval.Day)
            //    .CreateLogger();
            //builder.Logging.ClearProviders();
            #endregion

            // Added Serilog from file
            var fromFile = new LoggerConfiguration()
                            .ReadFrom.Configuration(builder.Configuration)
                            .CreateLogger();


            logging.AddSerilog(fromFile);
            Serilog.Debugging.SelfLog.Enable(msg =>
            {
                Debug.Print(msg);
                Debugger.Break();
            });
        }
    }
}
