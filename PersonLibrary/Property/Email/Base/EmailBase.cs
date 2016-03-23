namespace PersonLibrary.Property.Email.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;

    [Validator(typeof(EmailInterfaceValidator))]
    public abstract class EmailBase : IEmail
    {
        protected EmailBase(string emailAddress)
        {
            Contract.Requires(emailAddress != null);
            this.Email = emailAddress;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Email != null);
        }

        public string Email { get; }

        public override string ToString() => $"[ {this.Email} ]";
    }
}