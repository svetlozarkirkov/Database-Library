namespace PersonLibrary.Core.Validation
{
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Email.Validation;

    public class SingleEmailPersonValidator : PersonValidator<ISingleEmailPerson>
    {
        public SingleEmailPersonValidator()
        {
            RuleFor(person => person.Email).SetValidator(new GeneralEmailValidator());
        }
    }
}