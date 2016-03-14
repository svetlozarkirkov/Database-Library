namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    internal class MultipleAddressesPersonInterfaceValidator : AbstractValidator<IMultipleAddressesPerson>
    {
        internal MultipleAddressesPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetAddresses())
                .SetCollectionValidator(new AddressInterfaceValidator())
                .WithName("Addresses");
        }
    }
}