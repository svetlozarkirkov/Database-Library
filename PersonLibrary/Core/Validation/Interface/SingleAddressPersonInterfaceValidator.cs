namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    public class SingleAddressPersonInterfaceValidator : AbstractValidator<ISingleAddressPerson>
    {
        public SingleAddressPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Address)
                .SetValidator(new AddressInterfaceValidator());
        }
    }
}