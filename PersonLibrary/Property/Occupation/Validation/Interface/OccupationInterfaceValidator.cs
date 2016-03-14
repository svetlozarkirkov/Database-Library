namespace PersonLibrary.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Property.Occupation.Interface;

    public class OccupationInterfaceValidator : AbstractValidator<IOccupation>
    {
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
        }
    }
}