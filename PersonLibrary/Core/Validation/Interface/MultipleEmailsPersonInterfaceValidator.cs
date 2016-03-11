namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    public class MultipleEmailsPersonInterfaceValidator : AbstractValidator<IMultipleEmailsPerson>
    {
        public MultipleEmailsPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Emails)
                .SetCollectionValidator(new GeneralEmailValidator());
        }
    }
}