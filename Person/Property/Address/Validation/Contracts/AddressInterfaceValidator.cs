namespace Person.Property.Address.Validation.Contracts
{
    using FluentValidation;
    using Person.Property.Address.Contracts;

    /// <summary>
    /// Class AddressInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IAddress}" />
    public class AddressInterfaceValidator : AbstractValidator<IAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressInterfaceValidator"/> class.
        /// </summary>
        public AddressInterfaceValidator()
        {
            this.RuleFor(personAddress => personAddress.Country)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Country");

            this.RuleFor(personAddress => personAddress.City)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("City");

            this.RuleFor(personAddress => personAddress.Street)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Street");

            this.RuleFor(personAddress => personAddress.PostCode)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Post code");
        }
    }
}