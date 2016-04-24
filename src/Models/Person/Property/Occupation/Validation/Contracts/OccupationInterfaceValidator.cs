namespace Person.Property.Occupation.Validation.Contracts
{
    using FluentValidation;

    using Person.Property.Address.Validation.Contracts;
    using Person.Property.Occupation.Contracts;

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
                .WithName("Company name");

            this.RuleFor(occ => occ.CompanyAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Company address");

            this.RuleFor(occ => occ.CompanyPhone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .WithName("Company phone");
        }
    }
}