namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    /// <summary>
    /// Base concrete implementation for EMAIL
    /// </summary>
    [Validator(typeof(EmailValidator<IEmail>))]
    public class Email : EmailBase
    {
        public Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}