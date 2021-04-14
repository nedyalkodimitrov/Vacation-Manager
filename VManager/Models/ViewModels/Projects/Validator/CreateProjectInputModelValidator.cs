using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Configuration.Validation;
using VManager.Models.ViewModels.Projects.InputModels;

namespace VManager.Models.ViewModels.Projects.Validator
{
    public class CreateProjectInputModelValidator :AbstractValidator<CreateProjectInputModel>
    {
        public CreateProjectInputModelValidator()
        {
            this.RuleFor(i => i.Name)
            .MaximumLength(ProjectValidationParams.Name_Max_Length)
            .MinimumLength(ProjectValidationParams.Name_Min_Length)
            .NotEmpty();

            this.RuleFor(i => i.Descritpion)
            .MaximumLength(ProjectValidationParams.Description_Max_Length)
            .MinimumLength(ProjectValidationParams.Description_Min_Length)
            .NotEmpty();

        }
    }
}

