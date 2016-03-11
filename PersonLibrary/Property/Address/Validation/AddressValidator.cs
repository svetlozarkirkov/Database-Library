namespace PersonLibrary.Property.Address.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressValidator<T> : AbstractValidator<T> where T : IAddress
    {
        public AddressValidator()
        {
            RuleFor(personAddress => personAddress.Country)
                .NotNull()
                .NotEmpty();

            RuleFor(personAddress => personAddress.City)
                .NotNull()
                .NotEmpty();

            RuleFor(personAddress => personAddress.Street)
                .NotNull()
                .NotEmpty();

            RuleFor(personAddress => personAddress.PostCode)
                .NotNull()
                .NotEmpty();
        }
    }
}