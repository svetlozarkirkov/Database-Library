namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Validation;

    [Validator(typeof(DotNetEmailValidator))]
    public class DotNetEmail : EmailBase
    {
        public DotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}