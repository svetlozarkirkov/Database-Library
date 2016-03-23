namespace PersonLibrary.Property.Phone.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Interface;
    using PersonLibrary.Property.Phone.Validation.Interface;

    [Validator(typeof(PhoneInterfaceValidator))]
    public abstract class PhoneBase : IPhone
    {
        protected PhoneBase(string phoneNumber)
        {
            Contract.Requires(phoneNumber != null);
            this.PhoneNumber = phoneNumber;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(PhoneNumber != null);
        }

        public string PhoneNumber { get; }
    }
}