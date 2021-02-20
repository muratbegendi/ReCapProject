using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(b => b.FirstName).NotEmpty();
            RuleFor(b => b.LastName).NotEmpty();
        }
    }
}
