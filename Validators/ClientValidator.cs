using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funda_Trabajo_Parcial.Validators
{
    class ClientValidator : AbstractValidator<cliente>
    {
        public ClientValidator()
        {
            RuleFor(x => x.nombreEmpresa).NotEmpty().MinimumLength(3).MaximumLength(40).WithMessage("El Nombre de empresa no puede estar vacio y debe ser mayor a 3 carac.");
            RuleFor(x => x.RUC.ToString()).NotEmpty().Length(11).Matches("^[0-9]+$").WithMessage("El texto debe tener exactamente 11 caracteres y ser solo números");
            //RuleFor(x => x.fechaRegistro).Must(ValidarFecha).WithMessage("La fecha debe ser mayor a la actual");
        }



        //protected bool ValidarFecha(DateTime fecha)
        //{
        //    DateTime fechaActual = DateTime.Now;

        //    if (fecha >= fechaActual) return true;
        //    else return false;
        //}
    }
}
