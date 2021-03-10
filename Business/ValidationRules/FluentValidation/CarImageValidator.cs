using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(ca => ca.CarId).NotEmpty();
            RuleFor(ca => ca.Id).NotEmpty();
            RuleFor(ca => ca.ImagePath).NotEmpty();

        }

    }
}
