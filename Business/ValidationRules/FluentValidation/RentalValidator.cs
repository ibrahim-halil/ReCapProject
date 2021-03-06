using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentalId).NotEmpty().WithMessage("Olmayan araba kiralanamaz");
            RuleFor(r => r.RentDate).GreaterThanOrEqualTo(DateTime.Now).WithMessage("Geçmiş günler için araba kiralayamazsınız");
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).WithMessage("Kiralama tarihi, dönüş tarihinden önce olmalıdır");
        }
    }
}
