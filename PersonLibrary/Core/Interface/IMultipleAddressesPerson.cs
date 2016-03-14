namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Address.Interface;

    public interface IMultipleAddressesPerson : IPerson
    {
        List<IAddress> Addresses { get; }

        void AddAddress(IAddress address);

        void RemoveAddress(int index);
    }
}