using Api.Services.Services;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenceService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<TaxaJuros, TaxaJuros>();
            serviceCollection.AddTransient<ITaxaJurosService, TaxaJurosService>();
        }
    }
}
