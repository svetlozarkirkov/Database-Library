namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Address.Interface;

    public interface IMultipleAddressesPerson : IPerson
    {
        IEnumerable<IAddress> Addresses { get; }
    }
}