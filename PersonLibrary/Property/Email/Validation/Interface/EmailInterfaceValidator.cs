namespace PersonLibrary.Property.Email.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    public class EmailInterfaceValidator : AbstractValidator<IEmail>
    {
        public EmailInterfaceValidator()
        {
            this.RuleFor(email => email.EmailAddress).NotNull().NotEmpty();
        }
    }
}