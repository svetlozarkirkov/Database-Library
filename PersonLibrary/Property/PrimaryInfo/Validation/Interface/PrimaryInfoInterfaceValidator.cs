namespace PersonLibrary.Property.PrimaryInfo.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.PrimaryInfo.Interface;

    public class PrimaryInfoInterfaceValidator : AbstractValidator<IPrimaryInfo>
    {
        public PrimaryInfoInterfaceValidator()
        {
            this.RuleFor(primaryInfo => primaryInfo.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("First name"); // Not L10N

            this.RuleFor(primaryInfo => primaryInfo.MiddleName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("Middle name"); // Not L10N

            this.RuleFor(primaryInfo => primaryInfo.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("Last name"); // Not L10N

            this.RuleFor(primaryInfo => primaryInfo.Egn)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(10)
                .WithName("EGN"); // Not L10N
        }
    }
}