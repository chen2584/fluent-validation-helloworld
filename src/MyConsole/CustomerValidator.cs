using FluentValidation;

namespace MyConsole
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Age).GreaterThan(0);
            RuleFor(x => x.Cats).NotNull()
                .WithMessage("Cats is required");

            RuleFor(x => x.Cats).Must(x => x.Count >= 2)
                .WithMessage("Cats must contains at least 2.");

            RuleForEach(x => x.Cats).NotEmpty();
            //.MinimumLength(2)
            //.WithMessage("Cat must have 2 length.");
        }
    }
}