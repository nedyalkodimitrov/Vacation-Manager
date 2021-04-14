using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Configuration.Validation;
using VManager.Models.ViewModels.Teams.InputModels;

namespace VManager.Models.ViewModels.Teams.Validators
{
    public class UpdateTeamInputModelValidator :AbstractValidator<UpdateTeamInputModel>
    {
        public UpdateTeamInputModelValidator()
        {
            this.RuleFor(i => i.NewName)
                .MaximumLength(TeamValidationParams.Name_Max_Length)
                .MinimumLength(TeamValidationParams.Name_Min_Length);

            this.RuleFor(i => i.ProjectId)
                .NotEmpty();
        }
    }
}

