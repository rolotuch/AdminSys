using AdminSys.Infraestructura.Persistencia.Contexto;
using AdminSys.Infraestructura.Persistencia.Interfaces;

namespace AdminSys.Infraestructura.Persistencia.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        //instanciar el contexto para la conexcion a la bd
        private readonly AdminSysContext _context;        

        public IRepositorioUsuario AdUsuario { get; private set; }

        //iniciamos el constructor
        public UnitOfWork(AdminSysContext context)
        {
            _context = context;
            AdUsuario = new RepositorioUsuario(_context);
        }       

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
