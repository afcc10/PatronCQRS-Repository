using Business.Contract;
using Business.Implement;
using DataAccess.Core.Contract;
using DataAccess.Core.Implements;
using DataAccess.Models;
using DataAccess.Models.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRepository(IServiceCollection services)
        {
            
            services.AddScoped<ITipoPermisoRepository, TipoPermisoRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            return services;
        }

        public static IServiceCollection AddServices(IServiceCollection services)
        {
           
            services.AddScoped<ITipoPermisoServices, TipoPermisoServices>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
            //  services.AddAutoMapper(typeof(TipoPermisoProfileMap));

            return services;
        }

        public static IServiceCollection AddDbContext(IServiceCollection services, string DefaultConnection)
        {
            services.AddDbContext<DbCrudContext>(options => options.UseSqlServer(DefaultConnection, b => b.MigrationsAssembly("N5")));
            return services;
        }
    }
}
