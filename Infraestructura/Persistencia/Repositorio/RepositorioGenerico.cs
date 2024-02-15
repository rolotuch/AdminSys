using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Comunes.Bases.Request;
using AdminSys.Infraestructura.Helpers;
using AdminSys.Infraestructura.Persistencia.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using AdminSysContext = AdminSys.Infraestructura.Persistencia.Contexto.AdminSysContext;

namespace AdminSys.Infraestructura.Persistencia.Repositorio
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : BaseEntidades
    {
        //iniciamos con la implementacion, primero llamamos al context
        private readonly AdminSysContext _context;
        private readonly DbSet<T> _entity;

        //generamos el constructor
        public RepositorioGenerico(AdminSysContext context)
        {
            _context = context;
            //aca configuramos el seteo de nuestra entidad y le colocamos un seteo de tipo generico
            _entity = _context.Set<T>();
        }

        //ahora mapeao o implementamos nuestros repositorios

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var getAll = await _entity
                .Where(x => x.MeEstado!.Equals("ACTIVADO")).AsNoTracking().ToListAsync(); //&& x.AuditDeleteUser == null && x.AuditDeleteDate == null).AsNoTracking().ToListAsync();

            return getAll!;
        }
        public async Task<T> GetByIdAsync(string id)
        {
            var getById = await _entity.AsNoTracking().FirstOrDefaultAsync(x => x.Id!.Equals(id));
            //es posible que debamos agreagar esto await _entity!.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id)); el signo de admiracion
            return getById!;
        }
        public async Task<bool> RegisterAsync(T entidad)
        {
            //entidad.ToUpper();
            //entidad.AuditCreateUser = 1; //este uno esta quemado, mas adelante le pasaremos el usuario que esta logueado en ese momento
            entidad.FechaCreacion = DateTime.Now;

            //entidad.MeEstado = entidad.MeEstado?.ToUpper()
            await _context.AddAsync(entidad);
            
            var reccordAffected = await _context.SaveChangesAsync();

            return reccordAffected > 0;
        }

        public async Task<bool> UpdateAsync(T entidad)
        {
            //entidad.AuditUpdateUser = 1;
            //entidad.AuditUpdateDate = DateTime.Now;
            

            _context.Update(entidad);
            //_context.Entry(entidad).Property(x => x.AuditCreateUser).IsModified = false; // no modifica estas columnas al momento de actualizar el registro
            _context.Entry(entidad).Property(x => x.FechaCreacion).IsModified = false; // no modifica estas columnas al momento de actualizar el registro
            _context.Entry(entidad).Property(x => x.Id).IsModified = false;
            _context.Entry(entidad).Property(x => x.Password2).IsModified = false;

            var reccordAffected = await _context.SaveChangesAsync();

            return reccordAffected > 0;
        }
        public async Task<bool> DeleteAsync(string id)
        {

            T entity = await GetByIdAsync(id);

            //entity!.AuditDeleteUser = 1;
            //entity.AuditDeleteDate = DateTime.Now;
            entity.MeEstado = "DESACTIVADO";

            _context.Update(entity);

            var reccordAffected = await _context.SaveChangesAsync();

            return reccordAffected > 0;
        }
        public IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = _entity;
            if (filter != null) query = query.Where(filter);
            return query;
        }

        public IQueryable<TDTO> Ordering<TDTO>(BasePaginacionRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = request.Order == "desc" ? queryable.OrderBy($"{request.Sort} descending") : queryable.OrderBy($"{request.Sort} ascending");

            if (pagination) queryDto = queryDto.Paginate(request);

            return queryDto;
        }
    }
}

//ahora se configura la inyeccion