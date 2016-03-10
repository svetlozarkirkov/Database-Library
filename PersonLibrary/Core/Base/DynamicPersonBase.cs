namespace PersonLibrary.Core.Base
{
    using System.Collections.Generic;
    using System.Text;
    using PersonLibrary.Core.Interface;

    public abstract class DynamicPersonBase : IDynamicPerson
    {
        protected readonly Dictionary<string, object> _properties;

        protected DynamicPersonBase()
        {
            this._properties = new Dictionary<string, object>();
        }

        public void AddProperty(string key, object value)
        {
            this._properties.Add(key, value);
        }

        public void RemoveProperty(string key)
        {
            this._properties.Remove(key);
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