namespace PersonLibrary.Property.Phone.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Base;
    using PersonLibrary.Property.Phone.Validation.Interface;

    [Validator(typeof(PhoneInterfaceValidator))]
    public class Phone : PhoneBase
    {
        public Phone(string phoneNumber) : base(phoneNumber)
        {
        }
    }
}