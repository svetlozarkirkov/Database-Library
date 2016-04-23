namespace Person.Property.Email.Contracts
{
    using Person.Property.Core.Contracts;

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