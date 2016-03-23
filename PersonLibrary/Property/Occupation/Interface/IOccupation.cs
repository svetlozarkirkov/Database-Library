namespace PersonLibrary.Property.Occupation.Interface
{
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Core.Interface;
    using PersonLibrary.Property.Phone.Interface;

    /// <summary>
    /// Interface IOccupation
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Core.Interface.IProperty" />
    public interface IOccupation : IProperty
    {
        /// <summary>
        /// Gets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        string CompanyName { get; }

        /// <summary>
        /// Gets the company address.
        /// </summary>
        /// <value>The company address.</value>
        IAddress CompanyAddress { get; }

        /// <summary>
        /// Gets the company phone.
        /// </summary>
        /// <value>The company phone.</value>
        IPhone CompanyPhone { get; }
    }
}