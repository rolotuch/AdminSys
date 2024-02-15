namespace AdminSys.Infraestructura.Persistencia.Interfaces
{
    //manejo de transacciones en la implementacion
    public interface IUnitOfWork : IDisposable
    {
        //declaracion de nuestras interfaces a nivel de repositorio
        IRepositorioUsuario AdUsuario { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
