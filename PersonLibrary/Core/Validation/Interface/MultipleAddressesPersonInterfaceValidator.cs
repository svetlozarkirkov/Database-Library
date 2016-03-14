namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class MultipleAddressesPersonInterfaceValidator
        : ValidatorSingletonBase<IMultipleAddressesPerson>
    {
        public MultipleAddressesPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetAddresses())
                .SetCollectionValidator(AddressInterfaceValidator.GetInstance())
                .WithName("Addresses");
        }
    }
}