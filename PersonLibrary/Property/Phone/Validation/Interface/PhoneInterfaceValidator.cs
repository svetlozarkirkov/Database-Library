namespace PersonLibrary.Property.Phone.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;

    internal class PhoneInterfaceValidator : AbstractValidator<IPhone>
    {
        internal PhoneInterfaceValidator()
        {
            this.RuleFor(phone => phone.GetPhoneNumber())
                .NotNull()
                .NotEmpty()
                .WithName("Phone");
        }
    }
}