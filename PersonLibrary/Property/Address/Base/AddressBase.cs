﻿namespace PersonLibrary.Property.Address.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Address.Validation.Interface;

    [Validator(typeof(AddressInterfaceValidator))]
    public abstract class AddressBase : IAddress
    {
        private readonly string _country;
        private readonly string _city;
        private readonly string _street;
        private readonly string _postcode;

        protected AddressBase(string country, string city, string street, string postCode)
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._postcode = postCode;
        }

        public string Country => this._country;
        public string City => this._city;
        public string Street => this._street;
        public string PostCode => this._postcode;

        public override string ToString() => $"{{ [ Country: {this._country} ] [ City: {this._city} ] [ Street: {this._street} ] [ PostCode: {this._postcode} ] }}";
    }
}