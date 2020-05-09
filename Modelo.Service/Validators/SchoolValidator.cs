using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Is necessary to inform the Name.")
                .NotNull().WithMessage("Is necessary to inform the Name.");

            RuleFor(c => c.Tell)
                .NotEmpty().WithMessage("Is necessary to inform the Tell.")
                .NotNull().WithMessage("Is necessary to inform the Tell.");

            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Is necessary to inform the Address.")
                .NotNull().WithMessage("Is necessary to inform the Address.");
        }
    }
}
