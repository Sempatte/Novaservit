﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funda_Trabajo_Parcial.Validators
{
    class ProjectValidator : AbstractValidator<proyecto>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.costo).NotEmpty().GreaterThan(0.01M).WithMessage("El costo debe ser mayor a S/0.01");
            RuleFor(x => x.fecha_inicio).Must(BeAValidDate).Must(ValidarFecha).WithMessage("Start date is required").WithMessage("La fecha debe ser mayor a la actual");
            RuleFor(x => x.nombre).MinimumLength(10).MaximumLength(100).NotEmpty();
            
        }

        protected bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

        protected bool ValidarFecha(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            if (fecha > fechaActual) return true;
            else return false;
        }
    }
}