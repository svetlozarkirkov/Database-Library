namespace Person.Property.Phone.Contracts
{
    using Person.Property.Core.Contracts;

    /// <summary>
    /// Interface IPhone
    /// </summary>
    /// <seealso cref="IProperty" />
    public interface IPhone : IProperty
    {
        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        string PhoneNumber { get; }
    }
}