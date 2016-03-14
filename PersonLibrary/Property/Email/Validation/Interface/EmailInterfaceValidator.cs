namespace PersonLibrary.Property.Email.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    internal class EmailInterfaceValidator : AbstractValidator<IEmail>
    {
        internal EmailInterfaceValidator()
        {
            this.RuleFor(email => email.Email())
                .NotNull()
                .NotEmpty()
                .WithName("E-mail");
        }
    }
}