namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    [Validator(typeof(DotNetEmailValidator<IPersonDotNetEmail>))]
    public class PersonDotNetEmail : EmailBase, IPersonDotNetEmail
    {
        public PersonDotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}