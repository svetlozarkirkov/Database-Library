namespace PersonLibrary.Property.Email.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class EmailInterfaceValidator : ValidatorSingletonBase<IEmail>
    {
        public EmailInterfaceValidator()
        {
            this.RuleFor(email => email.Email())
                .NotNull()
                .NotEmpty()
                .WithName("E-mail");
        }
    }
}