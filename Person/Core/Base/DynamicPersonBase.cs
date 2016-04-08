namespace Person.Core.Base
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Text;
    using FluentValidation.Attributes;
    using Person.Core.Interface;
    using Person.Core.Validation.Interface;
    using Person.ExceptionHandling.Concrete;
    using Person.Property.Core.Interface;

    /// <summary>
    /// Class DynamicPersonBase.
    /// </summary>
    /// <seealso cref="IDynamicPerson" />
    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public abstract class DynamicPersonBase : IDynamicPerson
    {
        protected DynamicPersonBase()
        {
            this.Properties = new Dictionary<Type, IProperty>();
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public Dictionary<Type, IProperty> Properties { get; }

        /// <summary>
        /// Adds the given property to the person.
        /// </summary>
        /// <param name="property">The property to be added.</param>
        /// <param name="replaceIfExists">Whether to replace the existing property.</param>
        /// <exception cref="PropertyIsNullException">Property is null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="property" /> is null.</exception>
        /// <exception cref="InvalidPropertyOverwriteException">Cannot overwrite existing property.</exception>
        public void AddProperty(IProperty property, bool replaceIfExists = true)
        {
            Contract.Requires(property != null);

            if (property == null)
            {
                throw new PropertyIsNullException(nameof(property), "Property is null."); // Not L10N
            }

            var propertyType = property.GetType();

            if (!this.Properties.ContainsKey(propertyType))
            {
                this.Properties.Add(propertyType, property);
            }
            else
            {
                if (replaceIfExists)
                {
                    this.Properties[propertyType] = property;
                }
                else
                {
                    throw new InvalidPropertyOverwriteException("Cannot overwrite existing property."); // Not L10N
                }
            }
        }

        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="propertyType">Type of the property.</param>
        /// <returns>IProperty.</returns>
        /// <exception cref="PropertyTypeIsNullException">Condition.</exception>
        /// <exception cref="PropertyNotFoundException">Property not found.</exception>
        /// <exception cref="ArgumentNullException">Condition.</exception>
        /// <exception cref="KeyNotFoundException">Property not found.</exception>
        /// <exception cref="NotSupportedException"><paramref name="propertyType" /> is null.</exception>
        public IProperty GetProperty(Type propertyType)
        {
            if (propertyType == null)
            {
                throw new PropertyTypeIsNullException(nameof(propertyType), "Property Type is null."); // Not L10N
            }

            if (!this.Properties.ContainsKey(propertyType))
            {
                throw new PropertyNotFoundException("Property not found."); // Not L10N
            }

            return this.Properties[propertyType];
        }

        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="propertyType">Type of the property.</param>
        /// <exception cref="PropertyTypeIsNullException">Property type is null.</exception>
        /// <exception cref="PropertyNotFoundException">Condition.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="propertyType" /> is null.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        public void RemoveProperty(Type propertyType)
        {
            Contract.Requires(propertyType != null);

            if (propertyType == null)
            {
                throw new PropertyTypeIsNullException(nameof(propertyType), "Property Type is null."); // Not L10N
            }

            if (this.Properties.ContainsKey(propertyType))
            {
                this.Properties.Remove(propertyType);
            }
            else
            {
                throw new PropertyNotFoundException(); // Not L10N
            }
        }

        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var property in this.Properties)
            {
                result.Append($"{{\n\t[ Property Type: {property.Key.Name} ]\n\t[ Value: {property.Value} ]\n\r}}\n");
            }

            return result.ToString();
        }
    }
}