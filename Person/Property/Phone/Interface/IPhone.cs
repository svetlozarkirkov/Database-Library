namespace Person.Property.Phone.Interface
{
    using Person.Property.Core.Interface;

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