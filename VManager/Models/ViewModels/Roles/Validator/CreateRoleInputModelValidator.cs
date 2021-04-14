using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Configuration.Validation;
using VManager.Models.ViewModels.Roles.InputModels;

namespace VManager.Models.ViewModels.Roles.Validator
{
    public class CreateRoleInputModelValidator : AbstractValidator<CreateRoleInputModel>
    {
        public CreateRoleInputModelValidator()
        {
            this.RuleFor(im => im.Name)
                .NotEmpty()
                .MaximumLength(RoleValidationParams.Name_Max_Length)
                .MinimumLength(RoleValidationParams.Name_Min_Length);
        }
    }
}
