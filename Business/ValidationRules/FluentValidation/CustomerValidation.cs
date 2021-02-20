using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(b => b.CompanyName).NotEmpty();
            RuleFor(b => b.CompanyName).MinimumLength(5);
        }
    }
}
