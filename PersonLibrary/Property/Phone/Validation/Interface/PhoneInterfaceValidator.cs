namespace PersonLibrary.Property.Phone.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;

    /// <summary>
    /// Class PhoneInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IPhone}" />
    public class PhoneInterfaceValidator : AbstractValidator<IPhone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneInterfaceValidator"/> class.
        /// </summary>
        public PhoneInterfaceValidator()
        {
            // TODO: further checks
            this.RuleFor(phone => phone.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Phone"); // Not L10N
        }
    }
}