﻿namespace PersonLibrary.Property.Phone.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Phone.Interface;
    using PersonLibrary.Property.Phone.Validation.Interface;

    /// <summary>
    /// Class PhoneBase.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Phone.Interface.IPhone" />
    [Validator(typeof(PhoneInterfaceValidator))]
    public abstract class PhoneBase : IPhone
    {
        protected internal PhoneBase(string phoneNumber)
        {
            Contract.Requires(phoneNumber != null);
            this.PhoneNumber = phoneNumber;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(PhoneNumber != null);
        }

        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; }
    }
}