namespace PersonLibrary.Core.Interface
{
    using System;
    using System.Collections.Generic;
    using PersonLibrary.Property.Core.Interface;

    public interface IDynamicPerson
    {
        Dictionary<Type, IProperty> Properties { get; }

        void AddProperty(IProperty property);

        IProperty GetProperty(Type propertyType);

        void RemoveProperty(Type propertyType);
    }
}