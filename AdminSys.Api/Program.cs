using AdminSys.Api.Extenciones;
using AdminSys.Aplicacion.Extenciones;
using AdminSys.Infraestructura.Extenciones;
using WatchDog;

//using AdminSys.Utilidades.encriptar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//se agrego
var Configuration = builder.Configuration;
var Cors = "Cors";
builder.Services.AddInjectionInfraestructure(Configuration);
builder.Services.AddInyeccionAplicacion(Configuration);

//autenticacion
builder.Services.AddAutenticacion(Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();

builder.Services.AddHttpContextAccessor();

//agregando lo CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();

        });
});


var app = builder.Build();

//le decimos que utilice los CORS o que los use
app.UseCors(Cors);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//watch dog
app.UseWatchDogExceptionLogger();

app.UseHttpsRedirection();

app.UseAuthentication(); // middleware para authenticacion

app.UseAuthorization();

app.MapControllers();

app.UseWatchDog(configuration =>
{
    configuration.WatchPageUsername = Configuration.GetSection("WatchDog:Username").Value;
    configuration.WatchPagePassword = Configuration.GetSection("WatchDog:Password").Value;
    
});

app.Run();

public partial class Program { } //esto es porque al momento de estan en la clase CustomWebApplicationFactory me indica que el program no es accesible