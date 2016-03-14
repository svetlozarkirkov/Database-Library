namespace PersonLibrary.Property.Address.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IAddress : IProperty
    {
        string Country { get; }

        string City { get; }

        string Street { get; }

        string PostCode { get; }
    }
}