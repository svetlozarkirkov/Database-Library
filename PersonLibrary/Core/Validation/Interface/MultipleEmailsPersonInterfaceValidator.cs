using PersonLibrary.Utilities.Validation;

namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    public class MultipleEmailsPersonInterfaceValidator
        : CompositeValidator<IMultipleEmailsPerson>
    {
        public MultipleEmailsPersonInterfaceValidator()
        {
            this.RegisterBaseValidator(new PersonInterfaceValidator());

            this.RuleFor(p => p.EmailAddresses)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetCollectionValidator(new GeneralEmailValidator());
        }
    }
}