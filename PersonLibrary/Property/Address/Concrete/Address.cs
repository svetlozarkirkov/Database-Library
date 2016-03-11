namespace PersonLibrary.Property.Address.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Base;
    using PersonLibrary.Property.Address.Validation.Interface;

    [Validator(typeof(AddressInterfaceValidator))]
    public class Address : AddressBase
    {
        public Address(string country, string city, string street, string postCode)
            : base(country, city, street, postCode)
        {
        }
    }
}