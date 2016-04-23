namespace Person.Property.Occupation.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using Person.Property.Address.Contracts;
    using Person.Property.Occupation.Contracts;
    using Person.Property.Occupation.Validation.Contracts;
    using Person.Property.Phone.Contracts;

    /// <summary>
    /// Class OccupationBase.
    /// </summary>
    /// <seealso cref="IOccupation" />
    [Validator(typeof(OccupationInterfaceValidator))]
    public abstract class OccupationBase : IOccupation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccupationBase"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="companyAddress">The company address.</param>
        /// <param name="companyPhone">The company phone.</param>
        /// TODO Edit XML Comment Template for #ctor
        protected OccupationBase
            (string companyName, IAddress companyAddress, IPhone companyPhone)
        {
            Contract.Requires(companyName != null);
            Contract.Requires(companyAddress != null);
            Contract.Requires(companyPhone != null);
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
            this.CompanyPhone = companyPhone;
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