using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation :AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(b => b.ColorName).NotEmpty();
            RuleFor(b => b.ColorName).MinimumLength(5);
        }
    }
}
