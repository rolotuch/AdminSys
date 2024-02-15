namespace AdminSys.Aplicacion.Dtos.Usuario.Request
{
    public class UserRequestDto
    {
        public string? Id { get; set; }
        public string? Password2 { get; set; }
        public string? Email { get; set; }
        public string? Nombre { get; set; }
        public string? Puesto { get; set; }
        public string? Directiva { get; set; }
        public string? SesionMultiple { get; set; }
        public string? MeEstado { get; set; }
        //public string? AuthType { get; set; }

    }
}
