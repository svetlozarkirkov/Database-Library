namespace PersonLibrary.Property.Email.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;

    [Validator(typeof(EmailInterfaceValidator))]
    public abstract class EmailBase : IEmail
    {
        private readonly string _email;

        protected EmailBase(string emailAddress)
        {
            this._email = emailAddress;
        }

        public string Email => this._email;

        public override string ToString() => $"Email: [ {this._email} ]";
    }
}