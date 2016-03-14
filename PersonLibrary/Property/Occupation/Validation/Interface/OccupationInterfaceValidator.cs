namespace PersonLibrary.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Property.Occupation.Interface;

    public class OccupationInterfaceValidator : AbstractValidator<IOccupation>
    {
        public OccupationInterfaceValidator()
        {
            this.RuleFor(occ => occ.GetCompanyName())
                .NotNull()
                .NotEmpty()
                .WithName("Company name");

            this.RuleFor(occ => occ.GetCompanyAddress())
                .NotNull()
                .SetValidator(new AddressInterfaceValidator())
                .WithName("Company address");
        }
    }
}