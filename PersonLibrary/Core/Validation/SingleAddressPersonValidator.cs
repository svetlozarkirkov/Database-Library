namespace PersonLibrary.Core.Validation
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation;

    public class SingleAddressPersonValidator : PersonValidator<ISingleAddressPerson>
    {
        public SingleAddressPersonValidator()
        {
            RuleFor(person => person.Address)
                .NotNull()
                .SetValidator(new AddressValidator<IAddress>());
        }
    }
}