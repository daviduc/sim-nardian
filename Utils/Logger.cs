// File: Utils/Logger.cs
using Serilog;
using System;

namespace Utils
{
    public static class Logger
    {
        public static ILogger Instance { get; }

        static Logger()
        {
            Instance = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(
                    path: "logs/log.txt",
                    fileSizeLimitBytes: 100_000 * 100, // 100,000 lines assuming an average of 100 bytes per line
                    rollOnFileSizeLimit: true,
                    shared: true,
                    flushToDiskInterval: TimeSpan.FromSeconds(1),
                    retainedFileCountLimit: null, // Keep all log files
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();
        }
        public static void LogInformation(string message)
        {
            Instance.Information(message);
        }

        public static void LogError(Exception ex, string message)
        {
            Instance.Error(ex, message);
        }
    }
}
