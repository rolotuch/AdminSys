using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSys.Aplicacion.Dtos.Usuario.Request
{
    public class UserRequestUpdateDto
    {
        //public string? Id { get; set; }
        public string? Email { get; set; }
        public string? Nombre { get; set; }
        public string? Puesto { get; set; }
        public string? Directiva { get; set; }
        public string? SesionMultiple { get; set; }
        public string? MeEstado { get; set; }

    }
}
