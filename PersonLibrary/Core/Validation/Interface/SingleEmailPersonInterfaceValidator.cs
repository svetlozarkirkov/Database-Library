namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    public class SingleEmailPersonInterfaceValidator
        : AbstractValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonInterfaceValidator()
        {
            this.RuleFor(p => p.GetEmailAddress())
                .NotNull()
                .SetValidator(new GeneralEmailValidator())
                .WithName("E-mail address");
        }
    }
}