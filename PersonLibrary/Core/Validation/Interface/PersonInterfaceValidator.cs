namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        public PersonInterfaceValidator()
        {
            this.RuleFor(p => p.GetPersonInfo())
                .NotNull()
                .SetValidator(new PersonInfoInterfaceValidator())
                .WithName("Person info");
        }
    }
}