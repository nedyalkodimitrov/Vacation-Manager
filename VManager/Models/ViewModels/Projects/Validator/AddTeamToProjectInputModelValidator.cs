using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models.ViewModels.Projects.InputModels;

namespace VManager.Models.ViewModels.Projects.Validator
{
    public class AddUserToRoleModelValidator : AbstractValidator<AddTeamToProjectInputModel>
    {
        public AddUserToRoleModelValidator()
        {
            this.RuleFor(i => i.TeamId)
                .NotEmpty();
        }
    }
}
