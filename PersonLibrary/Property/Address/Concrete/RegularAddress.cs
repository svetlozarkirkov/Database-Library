namespace PersonLibrary.Property.Address.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Base;
    using PersonLibrary.Property.Address.Validation.Concrete;

    [Validator(typeof(RegularAddressValidator))]
    public class RegularAddress : AddressBase
    {
        public RegularAddress(string country, string city, string street, string postCode)
            : base(country, city, street, postCode)
        {
        }
    }
}