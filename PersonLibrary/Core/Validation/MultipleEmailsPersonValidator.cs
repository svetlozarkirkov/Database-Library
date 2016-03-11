namespace PersonLibrary.Core.Validation
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    public class MultipleEmailsPersonValidator : PersonValidator<IMultipleEmailsPerson>
    {
        public MultipleEmailsPersonValidator()
        {
            RuleFor(person => person.Emails)
                .SetCollectionValidator(new GeneralEmailValidator<IPersonGeneralEmail>());
        }
    }
}