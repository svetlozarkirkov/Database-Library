namespace PersonLibrary.Core.Base
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Core.Interface;

    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public abstract class DynamicPersonBase : IDynamicPerson
    {
        protected readonly Dictionary<string, IProperty> _properties;

        protected DynamicPersonBase()
        {
            this._properties = new Dictionary<string, IProperty>();
        }

        public Dictionary<string, IProperty> GetProperties() => this._properties;

        public void AddProperty(string propertyName, IProperty property)
        {
            if (!this._properties.ContainsKey(propertyName))
            {
                this._properties.Add(propertyName, property);
            }
            else
            {
                this._properties[propertyName] = property;
            }
        }

        public void RemoveProperty(string propertyName)
        {
            if (this._properties.ContainsKey(propertyName))
            {
                this._properties.Remove(propertyName);
            }
            else
            {
                throw new ArgumentException("Cannot remove property - it does not exist.");
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var property in this._properties)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                result.Append($"{{\n\t[ Key: {property.Key} ]\n\t[ Value: {property.Value} ]\n\r}}\n");
            }

            return result.ToString();
        }
    }
}