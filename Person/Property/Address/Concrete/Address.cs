namespace Person.Property.Address.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Address.Base;
    using Person.Property.Address.Validation.Interface;

    /// <summary>
    /// Class Address.
    /// </summary>
    /// <seealso cref="AddressBase" />
    [Validator(typeof(AddressInterfaceValidator))]
    public class Address : AddressBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="city">The city.</param>
        /// <param name="street">The street.</param>
        /// <param name="postCode">The post code.</param>
        public Address(string country, string city, string street, string postCode)
            : base(country, city, street, postCode)
        {
        }
    }
}