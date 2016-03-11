namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Validation.Interface;

    [Validator(typeof(EmailInterfaceValidator))]
    public class Email : EmailBase
    {
        protected Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}