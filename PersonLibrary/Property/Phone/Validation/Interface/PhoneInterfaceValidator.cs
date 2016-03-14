namespace PersonLibrary.Property.Phone.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;

    public class PhoneInterfaceValidator : AbstractValidator<IPhone>
    {
        public PhoneInterfaceValidator()
        {
            // TODO: further checks
            this.RuleFor(phone => phone.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty();
        }
    }
}