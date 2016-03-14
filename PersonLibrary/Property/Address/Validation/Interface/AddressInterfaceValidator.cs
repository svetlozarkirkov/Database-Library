namespace PersonLibrary.Property.Address.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Address.Interface;

    public class AddressInterfaceValidator : AbstractValidator<IAddress>
    {
        public AddressInterfaceValidator()
        {
            this.RuleFor(personAddress => personAddress.GetCountry())
                .NotNull()
                .NotEmpty()
                .WithName("Country");

            this.RuleFor(personAddress => personAddress.GetCity())
                .NotNull()
                .NotEmpty()
                .WithName("City");

            this.RuleFor(personAddress => personAddress.GetStreet())
                .NotNull()
                .NotEmpty()
                .WithName("Street");

            this.RuleFor(personAddress => personAddress.GetPostCode())
                .NotNull()
                .NotEmpty()
                .WithName("Post code");
        }
    }
}