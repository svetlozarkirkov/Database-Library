namespace PersonLibrary.Property.Email.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation;

    /// <summary>
    /// Default abstraction for EMAIL
    /// </summary>
    [Validator(typeof(EmailValidator<IEmail>))]
    public abstract class EmailBase : IEmail
    {
        protected EmailBase(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public string EmailAddress { get; set; }

        public override string ToString() => $"Email: [ {this.EmailAddress} ]";
    }
}