namespace PersonLibrary.Core.Base
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Text;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.ExceptionHandling.Concrete;
    using PersonLibrary.Property.Core.Interface;

    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public abstract class DynamicPersonBase : IDynamicPerson
    {
        protected DynamicPersonBase()
        {
            this.Properties = new Dictionary<Type, IProperty>();
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Properties != null);
        }

        public Dictionary<Type, IProperty> Properties { get; }

        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="property" /> is null.</exception>
        /// <exception cref="PropertyIsNullException">Property is null.</exception>
        public void AddProperty(IProperty property)
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
                this.Properties[propertyType] = property;
            }
        }

        /// <exception cref="PropertyTypeIsNullException">Condition.</exception>
        /// <exception cref="PropertyNotFoundException">Property not found.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="propertyType" /> is null.</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and <paramref name="propertyType" /> is not found.</exception>
        /// <exception cref="NotSupportedException">The property is set and the <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
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

        /// <exception cref="ArgumentNullException"><paramref name="propertyType" /> is null.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="PropertyNotFoundException">Condition.</exception>
        /// <exception cref="PropertyTypeIsNullException">Property type is null.</exception>
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