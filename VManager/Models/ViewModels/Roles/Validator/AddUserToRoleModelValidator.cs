using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models.ViewModels.Roles.InputModels;

namespace VManager.Models.ViewModels.Roles.Validator
{
    public class AddUserToRoleModelValidator : AbstractValidator<AddUserToRoleModel>
    {
        public AddUserToRoleModelValidator()
        {
            this.RuleFor(i => i.UserId)
                .NotEmpty();
        }
    }
}
