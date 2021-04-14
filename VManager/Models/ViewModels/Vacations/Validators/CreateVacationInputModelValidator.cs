using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Configuration.Validation;
using VManager.Models.ViewModels.Vacations.InputModels;

namespace VManager.Models.ViewModels.Vacations.Validators
{
    public class CreateVacationInputModelValidator :AbstractValidator<CreateVacationInputModel>
    {
        public CreateVacationInputModelValidator()
        {
            this.RuleFor(i => i.DateFrom)
                .NotEmpty();

            this.RuleFor(i => i.DateTo)
                .GreaterThanOrEqualTo(i => i.DateFrom)
                .NotEmpty();

            this.RuleFor(i => i.QueryCreationDate)
                .NotEmpty();

            this.RuleFor(i => i.Type)
                .NotEqual(VacationType.None)
                .IsInEnum()
                .NotEmpty();
        }
    }
}
