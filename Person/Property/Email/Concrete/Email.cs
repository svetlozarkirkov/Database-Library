using FluentValidation.Attributes;
using Person.Property.Email.Base;
using Person.Property.Email.Validation.Interface;

namespace Person.Property.Email.Concrete
{
    [Validator(typeof(EmailInterfaceValidator))]
    internal class Email : EmailBase
    {
        protected Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}