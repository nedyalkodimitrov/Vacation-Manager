using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Configuration.Validation;

namespace VManager.Models.ViewModels.Teams.Validators
{
    public class CreateTeamInputModelValidator :AbstractValidator <CreateTeamInputModel>
    {
        public CreateTeamInputModelValidator()
        {
            this.RuleFor(i => i.Name)
                .NotEmpty()
                .MaximumLength(TeamValidationParams.Name_Max_Length)
                .MinimumLength(TeamValidationParams.Name_Min_Length);

            this.RuleFor(i => i.ProjectId)
                .NotEmpty();
        }
       
    }
}
