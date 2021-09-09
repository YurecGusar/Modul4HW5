using System;
using Microsoft.Extensions.DependencyInjection;
using Modul4HW5.DataAccess;
using Modul4HW5.Services;
using Modul4HW5.Services.Abstractions;

namespace Modul4HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAppConfigService, AppConfigService>()
                .AddDbContext<ApplicationContext>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
