namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Core.Interface;

    public interface IDynamicPerson
    {
        Dictionary<string, IProperty> GetProperties();

        void AddProperty(string propertyName, IProperty property);

        void RemoveProperty(string propertyName);
    }
}