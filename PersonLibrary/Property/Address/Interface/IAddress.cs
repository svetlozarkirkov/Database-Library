namespace PersonLibrary.Property.Address.Interface
{
    public interface IAddress
    {
        string Country { get; set; }

        string City { get; set; }

        string Street { get; set; }

        string PostCode { get; set; }
    }
}