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
        private IAddress _companyAddress;

        protected OccupationBase(string companyName)
        {
            this._companyName = companyName;
        }

        public string GetCompanyName() => this._companyName;

        public IAddress GetCompanyAddress() => this._companyAddress;
    }
}