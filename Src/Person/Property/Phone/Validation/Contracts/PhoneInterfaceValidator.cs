namespace Person.Property.Phone.Validation.Contracts
{
    using FluentValidation;
    using Person.Property.Phone.Contracts;

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
                .WithName("Phone");
        }
    }
}