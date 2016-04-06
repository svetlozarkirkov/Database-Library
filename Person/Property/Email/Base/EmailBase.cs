using System.Diagnostics.Contracts;
using FluentValidation.Attributes;
using Person.Property.Email.Interface;
using Person.Property.Email.Validation.Interface;

namespace Person.Property.Email.Base
{
    /// <summary>
    /// Class EmailBase.
    /// </summary>
    /// <seealso cref="IEmail" />
    [Validator(typeof(EmailInterfaceValidator))]
    public abstract class EmailBase : IEmail
    {
        protected EmailBase(string emailAddress)
        {
            Contract.Requires(emailAddress != null);
            this.Email = emailAddress;
        }

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => $"[ {this.Email} ]";
    }
}