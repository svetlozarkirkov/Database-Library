namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        public PersonInterfaceValidator()
        {
            RuleFor(person => person.GetPersonInfo())
                .SetValidator(new PersonInfoInterfaceValidator())
                .WithName("Person info");
        }
    }
}