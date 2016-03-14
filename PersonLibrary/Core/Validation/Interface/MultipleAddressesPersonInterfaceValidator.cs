namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    public class MultipleAddressesPersonInterfaceValidator
        : CompositeValidator<IMultipleAddressesPerson>
    {
        public MultipleAddressesPersonInterfaceValidator()
        {
            this.RegisterBaseValidator(new PersonInterfaceValidator());

            this.RuleFor(p => p.Addresses)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetCollectionValidator(new AddressInterfaceValidator())
                .WithName("Addresses");
        }
    }
}