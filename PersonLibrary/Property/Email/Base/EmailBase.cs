namespace PersonLibrary.Property.Email.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;

    /// <summary>
    /// Class EmailBase.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Email.Interface.IEmail" />
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