namespace Person.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using Person.Property.Address.Validation.Interface;
    using Person.Property.Occupation.Interface;

    /// <summary>
    /// Class OccupationInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IOccupation}" />
    public class OccupationInterfaceValidator : AbstractValidator<IOccupation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccupationInterfaceValidator"/> class.
        /// </summary>
        public OccupationInterfaceValidator()
        {
            this.RuleFor(occ => occ.CompanyName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Company name"); // Not L10N

            this.RuleFor(occ => occ.CompanyAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Company address"); // Not L10N

            this.RuleFor(occ => occ.CompanyPhone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Company phone"); // Not L10N
        }
    }
}