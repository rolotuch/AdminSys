using FluentValidation.Results;

namespace AdminSys.Aplicacion.Comunes.Bases
{
    public class BaseResponse<T>
    {
        public bool IsSucces { get; set; }
        public T? Data { get; set; }
        public string? Mensaje { get; set; }
        public IEnumerable<ValidationFailure>? Errores { get; set; }
    }
}
