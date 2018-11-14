using System;
using Delta.Trinity.DataAccess.Commands.Auth;
using FluentValidation;

namespace Delta.Trinity.DataAccess.Validators.Auth
{
    public abstract class AccountValidation<T> : AbstractValidator<T> where T : AccountCommand
    {
        protected void ValidateUserName()
        {
            RuleFor(c => c.Username)
                .NotEmpty().WithMessage("Please ensure you have entered a username.")
                .Length(6, 50).WithMessage("Your username must have between 6 and 50 characters");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .GreaterThan(0);
        }
    }
}