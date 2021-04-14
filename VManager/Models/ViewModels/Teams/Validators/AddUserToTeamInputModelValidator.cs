using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VManager.Models.ViewModels.Teams.InputModels;

namespace VManager.Models.ViewModels.Teams.Validators
{
        public class AddUserToTeamInputModelValidator : AbstractValidator<AddUserToTeamInputModel>
        {
            public AddUserToTeamInputModelValidator()
            {
                this.RuleFor(i => i.UserId)
                    .NotEmpty();
            }
        }
    
}
