namespace PersonLibrary.Property.Occupation.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Interface;
    using PersonLibrary.Property.Occupation.Validation.Interface;

    [Validator(typeof(OccupationInterfaceValidator))]
    public abstract class OccupationBase : IOccupation
    {
        public string CompanyName { get; set; }
        public IAddress CompanyAddress { get; set; }
    }
}