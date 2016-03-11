namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class MultipleAddressesPersonInterfaceValidator : AbstractValidator<IMultipleAddressesPerson>
    {
        public MultipleAddressesPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Addresses).NotNull();
        }
    }
}