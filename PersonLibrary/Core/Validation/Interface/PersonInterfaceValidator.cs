namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class PersonInterfaceValidator : ValidatorSingletonBase<IPerson>
    {
        public PersonInterfaceValidator()
        {
            this.RuleFor(person => person.GetPersonInfo())
                .NotNull()
                .SetValidator(PersonInfoInterfaceValidator.GetInstance())
                .WithName("Person info");
        }
    }
}