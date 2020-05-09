using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class ClassSchoolValidator : AbstractValidator<ClassSchool>
    {
        public ClassSchoolValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.SchoolId)
                .NotEmpty().WithMessage("Is necessary to inform the SchoolId.")
                .NotNull().WithMessage("Is necessary to inform the SchoolId.");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Is necessary to inform the Name.")
                .NotNull().WithMessage("Is necessary to inform the Name.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Is necessary to inform the Email.")
                .NotNull().WithMessage("Is necessary to inform the Email.");
        }
    }
}
