namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    [Validator(typeof(DotNetEmailValidator))]
    public class DotNetEmail : EmailBase, IDotNetEmail
    {
        public DotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}