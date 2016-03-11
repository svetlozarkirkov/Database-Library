namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class SingleEmailPersonInterfaceValidator : AbstractValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Email).NotNull();
        }
    }
}