using FluentValidation.Validators;

namespace PersonLibrary.Property.PersonInfo.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.PersonInfo.Interface;

    public class PersonInfoInterfaceValidator : AbstractValidator<IPersonInfo>
    {
        public PersonInfoInterfaceValidator()
        {
            this.RuleFor(personInfo => personInfo.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("First name");

            this.RuleFor(personInfo => personInfo.MiddleName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("Middle name");

            this.RuleFor(personInfo => personInfo.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithName("Last name");

            this.RuleFor(personInfo => personInfo.Egn)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .Length(10)
                .WithName("EGN");
        }
    }
}