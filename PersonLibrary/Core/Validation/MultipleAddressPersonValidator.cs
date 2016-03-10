namespace PersonLibrary.Core.Validation
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation;

    public class MultipleAddressPersonValidator : PersonValidator<IMultipleAddressesPerson>
    {
        public MultipleAddressPersonValidator()
        {
            RuleFor(person => person.Addresses)
                .NotNull()
                .SetCollectionValidator(new AddressValidator<IAddress>());
        }
    }
}