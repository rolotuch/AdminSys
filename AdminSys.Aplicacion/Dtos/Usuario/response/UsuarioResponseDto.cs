namespace AdminSys.Aplicacion.Dtos.Usuario.response
{
    public class UsuarioResponseDto
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? SesionMultiple { get; set; }
        public string? Directiva { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? MeEstado { get; set; }
        public string? EstadoDeUsuario { get; set; }
    }
}
