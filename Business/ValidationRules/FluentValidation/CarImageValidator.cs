using Entities.Concreate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(c => c.ImagePath).NotNull().WithMessage("ImagePath boş olamaz");
            //RuleFor(c => c.CarId).NotNull().WithMessage("CarId boş olamaz");
            //RuleFor(c => c.Id).NotNull().WithMessage("Id boş olamaz");

        }
    }
}