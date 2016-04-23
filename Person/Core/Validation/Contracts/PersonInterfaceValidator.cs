namespace Person.Core.Validation.Contracts
{
    using FluentValidation;
    using Person.Core.Contracts;
    using Person.Property.PrimaryInfo.Validation.Contracts;

    /// <summary>
    /// Class PersonInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IPerson}" />
    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInterfaceValidator"/> class.
        /// </summary>
        public PersonInterfaceValidator()
        {
            this.RuleFor(p => p.PrimaryInfo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new PrimaryInfoInterfaceValidator())
                .WithName("Primary info");
        }
    }
}