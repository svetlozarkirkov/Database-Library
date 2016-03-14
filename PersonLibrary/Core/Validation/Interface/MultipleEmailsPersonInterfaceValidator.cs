namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    internal class MultipleEmailsPersonInterfaceValidator : AbstractValidator<IMultipleEmailsPerson>
    {
        internal MultipleEmailsPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetEmailAddresses())
                .SetCollectionValidator(new GeneralEmailValidator())
                .WithName("E-mail addresses");
        }
    }
}