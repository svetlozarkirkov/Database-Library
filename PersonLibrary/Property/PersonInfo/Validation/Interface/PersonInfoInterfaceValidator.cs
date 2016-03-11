namespace PersonLibrary.Property.PersonInfo.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.PersonInfo.Interface;

    public class PersonInfoInterfaceValidator : AbstractValidator<IPersonInfo>
    {
        public PersonInfoInterfaceValidator()
        {
            this.RuleFor(personInfo => personInfo.FirstName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);

            this.RuleFor(personInfo => personInfo.SurName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);

            this.RuleFor(personInfo => personInfo.LastName)
                .NotNull()
                .NotEmpty()
                .Length(1, 20);

            this.RuleFor(personInfo => personInfo.Egn)
                .NotNull()
                .NotEmpty()
                .Length(10);
        }
    }
}