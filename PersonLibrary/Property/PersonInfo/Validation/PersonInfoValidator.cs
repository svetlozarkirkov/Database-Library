namespace PersonLibrary.Property.PersonInfo.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.PersonInfo.Interface;

    public class PersonInfoValidator<T> : AbstractValidator<T> where T : IPersonInfo
    {
        public PersonInfoValidator()
        {
            RuleFor(personInfo => personInfo.FirstName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);

            RuleFor(personInfo => personInfo.SurName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);

            RuleFor(personInfo => personInfo.LastName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);
        }
    }
}