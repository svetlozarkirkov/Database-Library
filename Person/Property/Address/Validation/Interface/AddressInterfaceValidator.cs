using FluentValidation;
using Person.Property.Address.Interface;

namespace Person.Property.Address.Validation.Interface
{
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
                .WithName("Country"); // Not L10N

            this.RuleFor(personAddress => personAddress.City)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("City"); // Not L10N

            this.RuleFor(personAddress => personAddress.Street)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Street"); // Not L10N

            this.RuleFor(personAddress => personAddress.PostCode)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Post code"); // Not L10N
        }
    }
}