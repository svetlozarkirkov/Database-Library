namespace PersonLibrary.Property.Address.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressInterfaceValidator : AbstractValidator<IAddress>
    {
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