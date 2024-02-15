namespace AdminSys.Dominio.Entities
{
    public abstract class BaseEntidades
    {
        public string? Id { get; set; }
        public string? Password2 { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? MeEstado { get; set; }

    }
}
