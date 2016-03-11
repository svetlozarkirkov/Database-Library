namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    [Validator(typeof(GeneralEmailValidator))]
    public class GeneralEmail : EmailBase, IGeneralEmail
    {
        public GeneralEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}