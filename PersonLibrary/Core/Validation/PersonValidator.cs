namespace PersonLibrary.Core.Validation
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;
    using PersonLibrary.Property.PersonInfo.Validation;

    public class PersonValidator<T> : AbstractValidator<T> where T : IPerson
    {
        public PersonValidator()
        {
            RuleFor(personBase => personBase.PersonInfo)
                .NotNull()
                .SetValidator(new PersonInfoValidator<IPersonInfo>());
        }
    }
}