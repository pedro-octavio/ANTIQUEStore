using ANTIQUEStore.Domain.Domain;
using FluentValidation;

namespace ANTIQUEStore.Domain.Validators
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The name cannot be empty.")
                .NotNull().WithMessage("The name cannot be null.")
                .MaximumLength(50).WithMessage("The maximum length of name is 50.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("The maximum length of description is 500.");

            RuleFor(x => x.Year)
                .MaximumLength(30).WithMessage("The maximum length of year is 30.");
        }
    }
}
