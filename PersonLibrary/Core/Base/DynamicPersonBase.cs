namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;

    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public abstract class DynamicPersonBase : IDynamicPerson
    {
        protected readonly Dictionary<string, object> _properties;

        protected DynamicPersonBase()
        {
            this._properties = new Dictionary<string, object>();
        }

        public void AddProperty(string key, object value)
        {
            if (!this._properties.ContainsKey(key))
            {
                this._properties.Add(key, value);
            }
            else
            {
                this._properties[key] = value;
            }
        }

        public void RemoveProperty(string key)
        {
            if (this._properties.ContainsKey(key))
            {
                this._properties.Remove(key);
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