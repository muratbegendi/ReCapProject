using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(2000).When(c => c.BrandId == 1).WithMessage("Bu araç lüks sınıfta fiyat 2000 tl üstünde olmalı");
            //BranId si 1 olanlar için fiyat 2000 veya üzeri olmalıdır
            //RuleFor(c => c.Description).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
