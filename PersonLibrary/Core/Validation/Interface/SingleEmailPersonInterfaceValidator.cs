namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;
    using PersonLibrary.Utilities.Validation;

    public class SingleEmailPersonInterfaceValidator
        : CompositeValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonInterfaceValidator()
        {
            this.RegisterBaseValidator(new PersonInterfaceValidator());

            this.RuleFor(p => p.EmailAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new GeneralEmailValidator())
                .WithName("E-mail address");
        }
    }
}