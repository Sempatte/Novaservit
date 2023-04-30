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
            RuleFor(x => x.nombreEmpresa).NotEmpty().MinimumLength(3).MaximumLength(40);
            RuleFor(x => x.RUC.ToString()).NotEmpty().WithMessage("Inserta un RUC válido.").MinimumLength(11).MaximumLength(11);
            RuleFor(x => x.fechaRegistro).Must(ValidarFecha).WithMessage("La fecha debe ser mayor a la actual");
        }



        protected bool ValidarFecha(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            if (fecha > fechaActual) return true;
            else return false;
        }
    }
}
