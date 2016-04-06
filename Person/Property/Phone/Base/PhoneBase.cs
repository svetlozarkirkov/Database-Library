namespace Person.Property.Phone.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using Person.Property.Phone.Interface;
    using Person.Property.Phone.Validation.Interface;

    /// <summary>
    /// Class PhoneBase.
    /// </summary>
    /// <seealso cref="IPhone" />
    [Validator(typeof(PhoneInterfaceValidator))]
    public abstract class PhoneBase : IPhone
    {
        protected PhoneBase(string phoneNumber)
        {
            Contract.Requires(phoneNumber != null);
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; }
    }
}