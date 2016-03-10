namespace PersonLibrary.Property.Address.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressValidator<T> : AbstractValidator<T> where T : IAddress
    {
        public AddressValidator()
        {
            RuleFor(personAddress => personAddress.Country)
                .NotEmpty()
                .NotNull();

            RuleFor(personAddress => personAddress.City)
                .NotEmpty()
                .NotNull();

            RuleFor(personAddress => personAddress.Street)
                .NotEmpty()
                .NotNull();

            RuleFor(personAddress => personAddress.PostCode)
                .NotEmpty()
                .NotNull();
        }
    }
}