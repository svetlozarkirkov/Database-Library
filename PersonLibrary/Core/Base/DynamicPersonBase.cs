namespace PersonLibrary.Core.Base
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Core;
    using PersonLibrary.Property.Core.Interface;

    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public abstract class DynamicPersonBase : IDynamicPerson
    {
        private readonly Dictionary<PropertyType, IProperty> _properties;

        protected DynamicPersonBase()
        {
            this._properties = new Dictionary<PropertyType, IProperty>();
        }

        public Dictionary<PropertyType, IProperty> GetProperties() => this._properties;

        /// <exception cref="ArgumentNullException"><paramref name="propertyType" /> is null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        public void AddProperty(PropertyType propertyType, IProperty property)
        {
            if (!this._properties.ContainsKey(propertyType))
            {
                this._properties.Add(propertyType, property);
            }
            else
            {
                this._properties[propertyType] = property;
            }
        }

        /// <exception cref="ArgumentNullException"><paramref name="propertyType" /> is null.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="ArgumentException">Cannot remove property - it does not exist.</exception>
        public void RemoveProperty(PropertyType propertyType)
        {
            if (this._properties.ContainsKey(propertyType))
            {
                this._properties.Remove(propertyType);
            }
            else
            {
                throw new ArgumentException("Cannot remove property - it does not exist."); // Not L10N
            }
        }

        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var property in this._properties)
            {
                result.Append($"{{\n\t[ Property Type: {property.Key} ]\n\t[ Value: {property.Value} ]\n\r}}\n");
            }

            return result.ToString();
        }
    }
}