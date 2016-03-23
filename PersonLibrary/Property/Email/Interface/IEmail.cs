namespace PersonLibrary.Property.Email.Interface
{
    using PersonLibrary.Property.Core.Interface;

    /// <summary>
    /// Interface IEmail
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Core.Interface.IProperty" />
    public interface IEmail : IProperty
    {
        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>The email.</value>
        string Email { get; }
    }
}