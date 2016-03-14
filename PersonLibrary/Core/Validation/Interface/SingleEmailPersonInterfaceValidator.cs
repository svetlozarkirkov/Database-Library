namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;
    using PersonLibrary.Utilities.Validation;

    internal class SingleEmailPersonInterfaceValidator
        : ValidatorSingletonBase<ISingleEmailPerson>
    {
        public SingleEmailPersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetEmailAddress())
                .SetValidator(GeneralEmailValidator.GetInstance())
                .WithName("E-mail address");
        }
    }
}