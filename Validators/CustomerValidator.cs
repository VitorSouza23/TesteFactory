using System;
using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Results;
using TesteFactory.Model;
using System.Linq;

namespace TesteFactory.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>, IValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.BirthDate)
                .LessThan(DateTime.Today)
                .GreaterThan(Customer.MinBithDate);

            RuleFor(c => c.CPF)
                .NotNull()
                .NotEmpty();
        }

        public bool IsValid(Customer entity, out IEnumerable<object> errors)
        {
            ValidationResult validation = base.Validate(entity);
            errors = validation.Errors.Select(e => e.ErrorMessage);
            return validation.IsValid;
        }
    }
}