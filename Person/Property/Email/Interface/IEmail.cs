using Person.Property.Core.Interface;

namespace Person.Property.Email.Interface
{
    /// <summary>
    /// Interface IEmail
    /// </summary>
    /// <seealso cref="IProperty" />
    public interface IEmail : IProperty
    {
        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>The email.</value>
        string Email { get; }
    }
}