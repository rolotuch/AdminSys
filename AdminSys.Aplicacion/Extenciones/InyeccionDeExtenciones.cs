using AdminSys.Aplicacion.Extenciones.WatchDog;
using AdminSys.Aplicacion.Interfaces;
using AdminSys.Aplicacion.Servicios;
using AdminSys.Aplicacion.Validaciones.Usuarios;
using AdminSys.Dominio.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdminSys.Aplicacion.Extenciones
{
    public static class InyeccionDeExtenciones
    {
        public static IServiceCollection AddInyeccionAplicacion(this IServiceCollection services, IConfiguration configuracion)

        {
            //tiempo de servicio del paquete usamos singleton
            services.AddSingleton(configuracion);

            //Inyectamos a nivel global los servicios de FluenValidations
            services.AddFluentValidation(options =>
            {
                _ = options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies().Where(p => !p.IsDynamic));
            });

            //services.AddTransient<IValidator<AdUsuario>, ValidacionUsuario>();
            //Inyectamos a nivel global el AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //Registramos como un Scoped la intefaz y los servicios            
            services.AddScoped<IAplicacionUsuario, UsuarioAplicacionServicio>();
            //autenticacion
            services.AddScoped<ILogginAplicacion, LogginAplicacion>();
            services.AddWatchDog();
            //services.AddWatchDog(configuracion);

            //retornamos los servicios
            return services;
        }
    }
}
