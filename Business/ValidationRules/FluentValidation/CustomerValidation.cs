using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(b => b.CompanyName).NotEmpty();
            RuleFor(b => b.CompanyName).MinimumLength(5);
        }
    }
}
