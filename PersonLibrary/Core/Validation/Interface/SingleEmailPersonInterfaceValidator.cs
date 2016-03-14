namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    internal class SingleEmailPersonInterfaceValidator : AbstractValidator<ISingleEmailPerson>
    {
        internal SingleEmailPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetEmailAddress())
                .SetValidator(new GeneralEmailValidator())
                .WithName("E-mail address");
        }
    }
}