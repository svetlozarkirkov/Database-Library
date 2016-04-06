﻿namespace Person.Property.Address.Interface
{
    using Person.Property.Core.Interface;

    /// <summary>
    /// Interface IAddress
    /// </summary>
    /// <seealso cref="IProperty" />
    public interface IAddress : IProperty
    {
        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        string Country { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>The city.</value>
        string City { get; }

        /// <summary>
        /// Gets the street.
        /// </summary>
        /// <value>The street.</value>
        string Street { get; }

        /// <summary>
        /// Gets the post code.
        /// </summary>
        /// <value>The post code.</value>
        string PostCode { get; }
    }
}