namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    internal class SingleAddressPersonInterfaceValidator : AbstractValidator<ISingleAddressPerson>
    {
        internal SingleAddressPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetAddress())
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Address");
        }
    }
}