namespace PersonLibrary.Property.Phone.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Interface;
    using PersonLibrary.Property.Phone.Validation.Interface;

    [Validator(typeof(PhoneInterfaceValidator))]
    public abstract class PhoneBase : IPhone
    {
        private readonly string _phoneNumber;

        protected PhoneBase(string phoneNumber)
        {
            this._phoneNumber = phoneNumber;
        }

        public string PhoneNumber => this._phoneNumber;
    }
}