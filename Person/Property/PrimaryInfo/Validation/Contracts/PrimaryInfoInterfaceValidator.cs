namespace Person.Property.PrimaryInfo.Validation.Contracts
{
    using FluentValidation;
    using Person.Property.PrimaryInfo.Contracts;

    /// <summary>
    /// Class PrimaryInfoInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IPrimaryInfo}" />
    public class PrimaryInfoInterfaceValidator : AbstractValidator<IPrimaryInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryInfoInterfaceValidator"/> class.
        /// </summary>
        public PrimaryInfoInterfaceValidator()
        {
            this.RuleFor(primaryInfo => primaryInfo.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("First name");

            this.RuleFor(primaryInfo => primaryInfo.MiddleName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("Middle name");

            this.RuleFor(primaryInfo => primaryInfo.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 25)
                .WithName("Last name");

            this.RuleFor(primaryInfo => primaryInfo.Egn)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(10)
                .WithName("EGN");
        }
    }
}