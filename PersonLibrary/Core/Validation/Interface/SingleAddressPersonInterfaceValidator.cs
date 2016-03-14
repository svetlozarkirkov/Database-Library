namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    public class SingleAddressPersonInterfaceValidator
        : CompositeValidator<ISingleAddressPerson>
    {
        public SingleAddressPersonInterfaceValidator()
        {
            this.RegisterBaseValidator(new PersonInterfaceValidator());

            this.RuleFor(p => p.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Address");
        }
    }
}