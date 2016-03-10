namespace PersonLibrary.Property.Address.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Base;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation;

    [Validator(typeof(AddressValidator<IAddress>))]
    public class PersonAddress : AddressBase
    {
        public PersonAddress(string country, string city, string street, string postCode)
            : base(country, city, street, postCode)
        {
        }
    }
}