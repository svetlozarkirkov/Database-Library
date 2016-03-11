namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        public PersonInterfaceValidator()
        {
            RuleFor(personBase => personBase.PersonInfo).NotNull();
        }
    }
}