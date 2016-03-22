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
            this.Email = emailAddress;
        }

        public string Email { get; }

        public override string ToString() => $"[ {this.Email} ]";
    }
}