namespace PersonLibrary.Property.Occupation.Base
{
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
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
            this.CompanyPhone = companyPhone;
        }

        public string CompanyName { get; }

        public IAddress CompanyAddress { get; }

        public IPhone CompanyPhone { get; }
    }
}