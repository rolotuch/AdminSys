using AdminSys.Infraestructura.Comunes.Bases.Request;
using System.Linq.Dynamic.Core;
// se implementa el helpers para que realice la paginacion generica
namespace AdminSys.Infraestructura.Helpers
{
    public static class QueryableHelpers
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePaginacionRequest request)
        {
            return queryable.Skip((request.NumPage - 1) * request.Records).Take(request.Records);            
        }
    }
}
