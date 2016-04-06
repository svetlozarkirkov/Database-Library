namespace Person.Property.Phone.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Phone.Base;
    using Person.Property.Phone.Validation.Interface;

    /// <summary>
    /// Class Phone.
    /// </summary>
    /// <seealso cref="PhoneBase" />
    [Validator(typeof(PhoneInterfaceValidator))]
    public class Phone : PhoneBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone"/> class.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        public Phone(string phoneNumber) : base(phoneNumber)
        {
        }
    }
}