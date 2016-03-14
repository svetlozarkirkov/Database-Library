namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    public class SingleEmailPersonInterfaceValidator : AbstractValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetEmailAddress())
                .SetValidator(new GeneralEmailValidator())
                .WithName("E-mail address");
        }
    }
}