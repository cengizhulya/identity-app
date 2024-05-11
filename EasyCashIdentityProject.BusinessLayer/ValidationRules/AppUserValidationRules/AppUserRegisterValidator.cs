using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username field cannot be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email field cannot be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Password field cannot be empty");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter max 30 characters");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Please enter min 2 characters");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Passwords do not match");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address");
        }
    }
}
