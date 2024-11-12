using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.AccessData.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace F_Ferias.AccessData;

  public static class Ioc {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IContenedorTrabajo, ContenedorTrabajo>();
            return services;

        }
    }
    