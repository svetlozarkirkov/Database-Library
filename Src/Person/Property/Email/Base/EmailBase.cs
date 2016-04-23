namespace Person.Property.Email.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using Person.Property.Email.Contracts;
    using Person.Property.Email.Validation.Interface;

    /// <summary>
    /// Class EmailBase.
    /// </summary>
    /// <seealso cref="IEmail" />
    [Validator(typeof(EmailInterfaceValidator))]
    public abstract class EmailBase : IEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBase"/> class.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// TODO Edit XML Comment Template for #ctor
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