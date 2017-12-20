using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace NetCoreLearning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //add providers
                //.ConfigureLogging((hostingContext, logging) =>
                //{
                //    logging.AddConsole();
                //    logging.AddDebug();
                //})

                //filter rules in code 
                //.ConfigureLogging(logging =>
                //    logging.AddFilter("System", LogLevel.Debug)
                //        .AddFilter<DebugLoggerProvider>("Microsoft", LogLevel.Trace))

                // setminimumlevel  default level is information
                // .ConfigureLogging(logging => logging.SetMinimumLevel(LogLevel.Warning))

                // filter function
                //.ConfigureLogging(logBuilder =>
                //{
                //       logBuilder.AddFilter((provider, category, logLevel) =>
                //       {
                //           if (provider == "Microsoft.Extensions.Logging.Console.ConsoleLoggerProvider" &&
                //               category == "TodoApi.Controllers.TodoController")
                //           {
                //               return false;
                //           }
                //           return true;
                //       });
                //   })
                .UseStartup<Startup>()
                .Build();
    }
}
