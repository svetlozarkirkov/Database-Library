namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    [Validator(typeof(GeneralEmailValidator<IPersonGeneralEmail>))]
    public class PersonGeneralEmail : EmailBase, IPersonGeneralEmail
    {
        public PersonGeneralEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}