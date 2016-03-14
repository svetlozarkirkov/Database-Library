namespace PersonLibrary.Property.PersonInfo.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.PersonInfo.Interface;

    internal class PersonInfoInterfaceValidator : AbstractValidator<IPersonInfo>
    {
        internal PersonInfoInterfaceValidator()
        {
            this.RuleFor(personInfo => personInfo.GetFirstName())
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("First name");

            this.RuleFor(personInfo => personInfo.GetSurName())
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("Surname");

            this.RuleFor(personInfo => personInfo.GetLastName())
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("Last name");

            this.RuleFor(personInfo => personInfo.GetEgn())
                .NotNull()
                .NotEmpty()
                .Length(10)
                .WithName("EGN");
        }
    }
}