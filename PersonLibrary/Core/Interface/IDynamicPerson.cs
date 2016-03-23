namespace PersonLibrary.Core.Interface
{
    using System;
    using System.Collections.Generic;
    using PersonLibrary.Property.Core.Interface;

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
        void AddProperty(IProperty property);

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