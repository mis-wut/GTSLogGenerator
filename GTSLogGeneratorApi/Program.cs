﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GTSLogGeneratorApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .ConfigureServices(services => services.AddAutofac())
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://0.0.0.0:5000")
                .UseStartup<Startup>();
    }
}
