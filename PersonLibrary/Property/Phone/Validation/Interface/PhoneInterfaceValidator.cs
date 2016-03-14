namespace PersonLibrary.Property.Phone.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;

    public class PhoneInterfaceValidator : AbstractValidator<IPhone>
    {
        public PhoneInterfaceValidator()
        {
            this.RuleFor(phone => phone.GetPhoneNumber())
                .NotNull()
                .NotEmpty();
        }
    }
}