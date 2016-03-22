namespace PersonLibrary.Property.Phone.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Interface;
    using PersonLibrary.Property.Phone.Validation.Interface;

    [Validator(typeof(PhoneInterfaceValidator))]
    public abstract class PhoneBase : IPhone
    {
        protected PhoneBase(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; }
    }
}