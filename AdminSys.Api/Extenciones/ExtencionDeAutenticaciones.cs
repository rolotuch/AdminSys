using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AdminSys.Api.Extenciones
{
    public static class ExtencionDeAutenticaciones
    {
        public static IServiceCollection AddAutenticacion(this IServiceCollection services, IConfiguration configuracion)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuracion["Jwt:Issuer"],
                        ValidAudience = configuracion["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuracion["Jwt:Secret"]))
                    };

                });
            return services;
        }
    }
}
