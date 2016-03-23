namespace PersonLibrary.Property.Occupation.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Interface;
    using PersonLibrary.Property.Occupation.Validation.Interface;
    using PersonLibrary.Property.Phone.Interface;

    /// <summary>
    /// Class OccupationBase.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Occupation.Interface.IOccupation" />
    [Validator(typeof(OccupationInterfaceValidator))]
    public abstract class OccupationBase : IOccupation
    {
        protected OccupationBase(string companyName, IAddress companyAddress, IPhone companyPhone)
        {
            Contract.Requires(companyName != null);
            Contract.Requires(companyAddress != null);
            Contract.Requires(companyPhone != null);
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
            this.CompanyPhone = companyPhone;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(CompanyName != null);
            Contract.Invariant(CompanyAddress != null);
            Contract.Invariant(CompanyPhone != null);
        }

        /// <summary>
        /// Gets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; }

        /// <summary>
        /// Gets the company address.
        /// </summary>
        /// <value>The company address.</value>
        public IAddress CompanyAddress { get; }

        /// <summary>
        /// Gets the company phone.
        /// </summary>
        /// <value>The company phone.</value>
        public IPhone CompanyPhone { get; }
    }
}