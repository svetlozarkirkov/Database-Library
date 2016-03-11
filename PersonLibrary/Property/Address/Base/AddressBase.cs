namespace PersonLibrary.Property.Address.Base
{
    using PersonLibrary.Property.Address.Interface;

    public abstract class AddressBase : IAddress
    {
        protected AddressBase(string country, string city, string street, string postCode)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.PostCode = postCode;
        }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostCode { get; set; }

        public override string ToString() => $"{{ [ Country: {this.Country} ] [ City: {this.City} ] [ Street: {this.Street} ] [ PostCode: {this.PostCode} ] }}";
    }
}