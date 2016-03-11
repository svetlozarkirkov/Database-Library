namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class MultipleEmailsPersonInterfaceValidator : AbstractValidator<IMultipleEmailsPerson>
    {
        public MultipleEmailsPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Emails).NotNull();
        }
    }
}