using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models.ViewModels.Vacations.InputModels;

namespace VManager.Models.ViewModels.Vacations.Validators
{
    public class UpdateVacationInputModelValidator :AbstractValidator<UpdateVacationInputModel>
    {
        public UpdateVacationInputModelValidator()
        {
            this.RuleFor(i => i.DateFrom)
                .NotEmpty();

            this.RuleFor(i => i.DateTo)
                .GreaterThanOrEqualTo(i => i.DateFrom)
                .NotEmpty();

            this.RuleFor(i => i.Type)
                .NotEqual(VacationType.None)
                .IsInEnum()
                .NotEmpty();

        }

    }
}
