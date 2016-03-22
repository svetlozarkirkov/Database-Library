namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Core;
    using PersonLibrary.Property.Core.Interface;

    public interface IDynamicPerson
    {
        Dictionary<PropertyType, IProperty> GetProperties();

        void AddProperty(PropertyType propertyType, IProperty property);

        void RemoveProperty(PropertyType propertyType);
    }
}