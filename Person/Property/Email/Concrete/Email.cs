namespace Person.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Email.Base;
    using Person.Property.Email.Validation.Interface;

    [Validator(typeof(EmailInterfaceValidator))]
    public class Email : EmailBase
    {
        public Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}