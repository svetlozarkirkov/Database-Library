namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    internal class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        internal PersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetPersonInfo())
                .SetValidator(new PersonInfoInterfaceValidator());
        }
    }
}