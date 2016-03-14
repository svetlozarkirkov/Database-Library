namespace PersonLibrary.Property.Occupation.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Interface;
    using PersonLibrary.Property.Occupation.Validation.Interface;

    [Validator(typeof(OccupationInterfaceValidator))]
    public abstract class OccupationBase : IOccupation
    {
        private readonly string _companyName;
        private readonly IAddress _companyAddress;

        protected OccupationBase(string companyName, IAddress companyAddress)
        {
            this._companyName = companyName;
            this._companyAddress = companyAddress;
        }

        public string CompanyName => this._companyName;

        public IAddress CompanyAddress => this._companyAddress;
    }
}