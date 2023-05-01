using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funda_Trabajo_Parcial.Validators
{
    class UserValidator : AbstractValidator<usuario>
    {


        public UserValidator()
        {
            RuleFor(x => x.username).NotEmpty().MinimumLength(6).MaximumLength(14).NotEqual("admin");
            RuleFor(x => x.email).EmailAddress().NotNull();
            RuleFor(x => x.password).NotEmpty().MinimumLength(8).MaximumLength(20);
        }
    }
}
