namespace PersonLibrary.Property.Address.Validation.Base
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressValidator<T> : AbstractValidator<T> where T : IAddress
    {
        public AddressValidator()
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