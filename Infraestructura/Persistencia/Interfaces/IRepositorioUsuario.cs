using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Commons.Bases.Response;
using AdminSys.Infraestructura.Comunes.Bases.Request;

namespace AdminSys.Infraestructura.Persistencia.Interfaces
{
    public interface IRepositorioUsuario : IRepositorioGenerico<AdUsuario>
    {
        Task<AdUsuario> CuentaByUsername(string username);
        Task<BaseEntityResponse<AdUsuario>> ListUsuario(BaseFiltersRequest filtros);
    }
}
