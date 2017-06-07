﻿namespace Server.Api
{
	using Microsoft.AspNetCore;
	using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>()
                   .UseConfiguration(new ConfigurationBuilder().AddEnvironmentVariables().Build())
                   //.UseUrls("http://*:5050")
                   .Build();
    }
}
