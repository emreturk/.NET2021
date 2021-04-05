using Entities.Concreate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            // Examples
            RuleFor(p => p.CarName).NotEmpty();
            //RuleFor(p => p.CarName).MinimumLength(2);
            //RuleFor(p => p.DailyPrice).NotEmpty();
            //RuleFor(p => p.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.Description).MinimumLength(3);
            //RuleFor(c => c.ModelYear).GreaterThan(1950);

        }

    //    private bool StartwithA(string arg)
    //    {
    //        return arg.StartsWith("A");
    //    }
    }
}
