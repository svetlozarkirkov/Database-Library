namespace PersonLibrary.Property.Occupation.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Interface;
    using PersonLibrary.Property.Occupation.Validation.Interface;
    using PersonLibrary.Property.Phone.Interface;

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

        public string CompanyName { get; }

        public IAddress CompanyAddress { get; }

        public IPhone CompanyPhone { get; }
    }
}