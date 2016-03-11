namespace PersonLibrary.Property.Address.Concrete
{
    using PersonLibrary.Property.Address.Base;

    internal class PersonAddress : AddressBase
    {
        protected PersonAddress(string country, string city, string street, string postCode)
            : base(country, city, street, postCode)
        {
        }
    }
}