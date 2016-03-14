namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;
    using PersonLibrary.Utilities.Validation;

    internal class MultipleEmailsPersonInterfaceValidator
        : ValidatorSingletonBase<IMultipleEmailsPerson>
    {
        public MultipleEmailsPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetEmailAddresses())
                .SetCollectionValidator(GeneralEmailValidator.GetInstance())
                .WithName("E-mail addresses");
        }
    }
}