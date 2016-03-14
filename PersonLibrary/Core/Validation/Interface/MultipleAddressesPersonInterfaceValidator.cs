namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    public class MultipleAddressesPersonInterfaceValidator
        : AbstractValidator<IMultipleAddressesPerson>
    {
        public MultipleAddressesPersonInterfaceValidator()
        {
            this.RuleFor(p => p.GetAddresses())
                .NotNull()
                .SetCollectionValidator(new AddressInterfaceValidator())
                .WithName("Addresses");
        }
    }
}