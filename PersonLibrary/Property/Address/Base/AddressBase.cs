namespace PersonLibrary.Property.Address.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    [Validator(typeof(AddressInterfaceValidator))]
    public abstract class AddressBase : IAddress
    {
        protected AddressBase(string country, string city, string street, string postCode)
        {
            Contract.Requires(country != null);
            Contract.Requires(city != null);
            Contract.Requires(street != null);
            Contract.Requires(postCode != null);
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.PostCode = postCode;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Country != null);
            Contract.Invariant(City != null);
            Contract.Invariant(Street != null);
            Contract.Invariant(PostCode != null);
        }

        public string Country { get; }

        public string City { get; }

        public string Street { get; }

        public string PostCode { get; }

        public override string ToString() => $"{{ [ Country: {this.Country} ] [ City: {this.City} ] [ Street: {this.Street} ] [ PostCode: {this.PostCode} ] }}";
    }
}