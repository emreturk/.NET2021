﻿using Entities.Concreate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //RuleFor(c => c.UserId).NotNull();
        }
    }
}
