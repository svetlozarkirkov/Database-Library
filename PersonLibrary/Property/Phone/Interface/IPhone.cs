namespace PersonLibrary.Property.Phone.Interface
{
    using PersonLibrary.Property.Core.Interface;

    /// <summary>
    /// Interface IPhone
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Core.Interface.IProperty" />
    public interface IPhone : IProperty
    {
        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        string PhoneNumber { get; }
    }
}