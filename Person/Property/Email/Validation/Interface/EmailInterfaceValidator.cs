using FluentValidation;
using Person.Property.Email.Interface;

namespace Person.Property.Email.Validation.Interface
{
    /// <summary>
    /// Class EmailInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IEmail}" />
    public class EmailInterfaceValidator : AbstractValidator<IEmail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailInterfaceValidator"/> class.
        /// </summary>
        public EmailInterfaceValidator()
        {
            this.RuleFor(email => email.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("E-mail"); // Not L10N
        }
    }
}