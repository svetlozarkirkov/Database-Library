namespace PersonLibrary.Property.Phone.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Base;
    using PersonLibrary.Property.Phone.Validation.Interface;

    /// <summary>
    /// Class Phone.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Phone.Base.PhoneBase" />
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