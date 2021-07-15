using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Modul2HW4
{
    public class AppStarter
    {
        public void Run()
        {
            var servicesProvider = new ServiceCollection()
                .AddTransient<IAnimalsProvider, AnimalProvider>()
                .AddTransient<IAnimalSortService, AnimalSortService>()
                .AddTransient<IMeasureConverterService, MeasureConverterService>()
                .AddTransient<IAviaryService, AviaryService>()
                .AddTransient<Startup>().BuildServiceProvider();
            var start = servicesProvider.GetService<Startup>();
            start.Run();
        }
    }
}
