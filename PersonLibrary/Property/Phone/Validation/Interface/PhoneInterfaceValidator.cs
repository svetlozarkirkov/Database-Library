namespace PersonLibrary.Property.Phone.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class PhoneInterfaceValidator : ValidatorSingletonBase<IPhone>
    {
        public PhoneInterfaceValidator()
        {
            this.RuleFor(phone => phone.GetPhoneNumber())
                .NotNull()
                .NotEmpty();
        }
    }
}