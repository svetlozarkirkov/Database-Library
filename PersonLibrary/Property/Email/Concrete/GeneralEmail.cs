namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Validation;

    [Validator(typeof(GeneralEmailValidator))]
    public class GeneralEmail : EmailBase
    {
        public GeneralEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}