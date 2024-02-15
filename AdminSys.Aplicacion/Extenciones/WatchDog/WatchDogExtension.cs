using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WatchDog;
using WatchDog.src.Enums;

namespace AdminSys.Aplicacion.Extenciones.WatchDog
{
    public static class WatchDogExtension
    {
        //public static IServiceCollection AddWatchDog( this IServiceCollection servicio, IConfiguration configuracion)
        public static IServiceCollection AddWatchDog(this IServiceCollection servicio)
        {
            servicio.AddWatchDogServices(options =>
            {
                //agregar los logs a la bd fisicamente
                //options.SetExternalDbConnString = configuracion.GetConnectionString("AdminSysConection"); no se puede usar en oracle
                //options.DbDriverOption = WatchDogDbDriverEnum.MSSQL;
                //options.SqlDriverOptions = WatchDogSqlDriverEnum.MSSql; //cambiar por oracle este esta para sql server
                //limpiar los logs diarios
                options.IsAutoClear = true;
                options.ClearTimeSchedule = WatchDogAutoClearScheduleEnum.Daily;
            });

            return servicio;
        }
    }
}
