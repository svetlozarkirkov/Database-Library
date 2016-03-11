namespace PersonLibrary.Core.Validation
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    public class SingleEmailPersonValidator : PersonValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonValidator()
        {
            RuleFor(person => person.Email)
                .NotNull()
                .SetValidator(new GeneralEmailValidator<IPersonGeneralEmail>());
        }
    }
}