using AdminSys.Infraestructura.Comunes.Bases.Request;
using System.Linq.Expressions;
//se inicia vacio y luego se implementa esta interfas esto es a niel de infraestructura repositorio

namespace AdminSys.Infraestructura.Persistencia.Interfaces
{
    public interface IRepositorioGenerico <T> where T : class
    {
        //se agregarn todos los metodos de un crud
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<bool> RegisterAsync(T entidad);
        Task<bool> UpdateAsync(T entidad);
        Task<bool> DeleteAsync(string id);
        IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null); //devuelve un queryable en base a la entidad que le pase
        IQueryable<TDTO> Ordering<TDTO>(BasePaginacionRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class;
    }
}
