namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PrimaryInfo.Validation.Interface;

    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        public PersonInterfaceValidator()
        {
            this.RuleFor(p => p.PrimaryInfo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new PrimaryInfoInterfaceValidator())
                .WithName("Primary info"); // Not L10N
        }
    }
}