namespace PersonLibrary.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Property.Occupation.Interface;

    internal class OccupationInterfaceValidator : AbstractValidator<IOccupation>
    {
        internal OccupationInterfaceValidator()
        {
            this.RuleFor(occ => occ.GetCompanyName())
                .NotNull()
                .NotEmpty()
                .WithName("Company name");

            this.RuleFor(occ => occ.GetCompanyAddress())
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Company address");
        }
    }
}