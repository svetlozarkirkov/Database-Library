namespace Person.Property.Address.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using Person.Property.Address.Contracts;
    using Person.Property.Address.Validation.Contracts;

    /// <summary>
    /// Class AddressBase.
    /// </summary>
    /// <seealso cref="IAddress" />
    [Validator(typeof(AddressInterfaceValidator))]
    public abstract class AddressBase : IAddress
    {
        protected AddressBase(string country, string city, string street, string postCode)
        {
            Contract.Requires(country != null);
            Contract.Requires(city != null);
            Contract.Requires(street != null);
            Contract.Requires(postCode != null);
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.PostCode = postCode;
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; }

        /// <summary>
        /// Gets the street.
        /// </summary>
        /// <value>The street.</value>
        public string Street { get; }

        /// <summary>
        /// Gets the post code.
        /// </summary>
        /// <value>The post code.</value>
        public string PostCode { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => $"{{ [ Country: {this.Country} ] [ City: {this.City} ] [ Street: {this.Street} ] [ PostCode: {this.PostCode} ] }}";
    }
}