namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class SingleAddressPersonInterfaceValidator
        : ValidatorSingletonBase<ISingleAddressPerson>
    {
        public SingleAddressPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetAddress())
                .SetValidator(AddressInterfaceValidator.GetInstance())
                .WithName("Address");
        }
    }
}