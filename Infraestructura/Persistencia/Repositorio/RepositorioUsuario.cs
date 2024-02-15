using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Commons.Bases.Response;
using AdminSys.Infraestructura.Comunes.Bases.Request;
using AdminSys.Infraestructura.Persistencia.Contexto;
using AdminSys.Infraestructura.Persistencia.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminSys.Infraestructura.Persistencia.Repositorio
{
    public class RepositorioUsuario : RepositorioGenerico<AdUsuario>, IRepositorioUsuario
    {
        private readonly AdminSysContext _context;


        public RepositorioUsuario(AdminSysContext context) : base(context)
        {
            _context = context;
        }

        public async Task<AdUsuario> CuentaByUsername(string Usuario)
        {
            var cuenta = await _context.AdUsuarios.AsNoTracking().FirstOrDefaultAsync(x => x.Id!.Equals(Usuario));
            return cuenta!;
        }

        public async Task<BaseEntityResponse<AdUsuario>> ListUsuario(BaseFiltersRequest filtros)
        {
            var response = new BaseEntityResponse<AdUsuario>();

            var usuario = GetEntityQuery(x => x.MeEstado == TiposDeEstados.Activo);

            //filtros por nombre y descripcion
            if (filtros.NumFilter is not null && !string.IsNullOrEmpty(filtros.TextFilter))
            {
                switch (filtros.NumFilter)
                {
                    case 1:
                        usuario = usuario.Where(x => x.Id!.Contains(filtros.TextFilter)); break;
                    case 2:
                        usuario = usuario.Where(x => x.Nombre!.Contains(filtros.TextFilter)); break;
                        //si ubieran mas casos aca los agreamos
                }
            }
            //filtros por estado
            if (filtros.StateFilter is not null)
            {
                usuario = usuario.Where(x => x.MeEstado!.Equals(filtros.StateFilter));
            }

            //filtros por fechas
            if (!string.IsNullOrEmpty(filtros.StartDate) && !string.IsNullOrEmpty(filtros.EndDate))
            {
                usuario = usuario.Where(x => x.FechaCreacion >= Convert.ToDateTime(filtros.StartDate) && x.FechaCreacion <= Convert.ToDateTime(filtros.EndDate).AddDays(1));
            }

            //filtros por paginacion ordenamiento

            if (filtros.Sort is null)
            {
                filtros.Sort = "Id"; //se cambio por el repositorio generico
            }

            response.TotalRecords = await usuario.CountAsync();
            response.Items = await Ordering(filtros, usuario).ToListAsync();
            //response.Items = await Ordering(filtros, usuario, !(bool)filtros.Download!).ToListAsync();

            return response;
        }

       
    }
}
