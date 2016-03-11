namespace PersonLibrary.Property.Address.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressInterfaceValidator : AbstractValidator<IAddress>
    {
        public AddressInterfaceValidator()
        {
            this.RuleFor(personAddress => personAddress.Country)
                .NotNull()
                .NotEmpty();

            this.RuleFor(personAddress => personAddress.City)
                .NotNull()
                .NotEmpty();

            this.RuleFor(personAddress => personAddress.Street)
                .NotNull()
                .NotEmpty();

            this.RuleFor(personAddress => personAddress.PostCode)
                .NotNull()
                .NotEmpty();
        }
    }
}