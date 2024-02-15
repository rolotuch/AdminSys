using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Persistencia.Contexto;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSys.Aplicacion.Validaciones.Usuarios
{
    public class ValidacionUsuario : AbstractValidator<UserRequestDto>
    {
        private readonly AdminSysContext _context;

        public ValidacionUsuario(AdminSysContext context)
        {
            _context = context;

            RuleFor(x => x.Id)
                .NotNull().WithMessage("El campo no puede ser nulo.")
                .NotEmpty().WithMessage("El campo no puede estar vacio.");
                //.Must(ValidarIdUnico).WithMessage("Ya existe un usuario con ese nombre, favor de elegir otro");
        }

        //private bool ValidarIdUnico(string id)
        //{
        //    var existingUser = _context.AdUsuarios
        //        .FirstOrDefault(x => x.Id == id);

        //    return existingUser == null;
        //}
    }
}
