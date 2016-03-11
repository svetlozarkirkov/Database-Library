namespace PersonLibrary.Property.Email.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;

    [Validator(typeof(EmailInterfaceValidator))]
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