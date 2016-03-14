namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    public class SingleAddressPersonInterfaceValidator
        : AbstractValidator<ISingleAddressPerson>
    {
        public SingleAddressPersonInterfaceValidator()
        {
            this.RuleFor(p => p.GetAddress())
                .NotNull()
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Address");
        }
    }
}