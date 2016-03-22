namespace PersonLibrary.Property.Address.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    [Validator(typeof(AddressInterfaceValidator))]
    public abstract class AddressBase : IAddress
    {
        protected AddressBase(string country, string city, string street, string postCode)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.PostCode = postCode;
        }

        public string Country { get; }

        public string City { get; }

        public string Street { get; }

        public string PostCode { get; }

        public override string ToString() => $"{{ [ Country: {this.Country} ] [ City: {this.City} ] [ Street: {this.Street} ] [ PostCode: {this.PostCode} ] }}";
    }
}