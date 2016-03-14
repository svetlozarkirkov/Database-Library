namespace PersonLibrary.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Validation.Interface;
    using PersonLibrary.Property.Occupation.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class OccupationInterfaceValidator : ValidatorSingletonBase<IOccupation>
    {
        public OccupationInterfaceValidator()
        {
            this.RuleFor(occ => occ.GetCompanyName())
                .NotNull()
                .NotEmpty()
                .WithName("Company name");

            this.RuleFor(occ => occ.GetCompanyAddress())
                .SetValidator(AddressInterfaceValidator.GetInstance())
                .WithName("Company address");
        }
    }
}