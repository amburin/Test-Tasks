﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WaybillService.Presentation
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
