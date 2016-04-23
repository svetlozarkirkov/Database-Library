namespace Person.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using Person.Property.Core.Contracts;

    /// <summary>
    /// Interface IDynamicPerson
    /// </summary>
    public interface IDynamicPerson
    {
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        Dictionary<Type, IProperty> Properties { get; }

        /// <summary>
        /// Adds the property.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <param name="replaceIfExists">if set to <c>true</c> [replace if exists].</param>
        void AddProperty(IProperty property, bool replaceIfExists);

        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="propertyType">Type of the property.</param>
        /// <returns>IProperty.</returns>
        IProperty GetProperty(Type propertyType);

        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="propertyType">Type of the property.</param>
        void RemoveProperty(Type propertyType);
    }
}