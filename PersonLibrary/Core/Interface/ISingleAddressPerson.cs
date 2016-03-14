namespace PersonLibrary.Core.Interface
{
    using PersonLibrary.Property.Address.Interface;

    public interface ISingleAddressPerson : IPerson
    {
        IAddress GetAddress();
    }
}