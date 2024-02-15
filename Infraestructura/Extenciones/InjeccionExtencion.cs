using AdminSys.Infraestructura.Persistencia.Contexto;
using AdminSys.Infraestructura.Persistencia.Interfaces;
using AdminSys.Infraestructura.Persistencia.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdminSys.Infraestructura.Extenciones
{
    public static class InjeccionExtencion
    {
        //AddInjectionInfraestructure este metodo lo configuramos globalmente en program cs
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuracion)
        {
            var assembly = typeof(AdminSysContext).Assembly.FullName;
            services.AddDbContext<AdminSysContext>(
                options => options.UseOracle(
                    configuracion.GetConnectionString("AdminSysConection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient
                );

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));

            return services;
        }

    }
    
}
