namespace PersonLibrary.Property.Occupation.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Base;
    using PersonLibrary.Property.Occupation.Validation.Interface;
    using PersonLibrary.Property.Phone.Interface;

    [Validator(typeof(OccupationInterfaceValidator))]
    public class Occupation : OccupationBase
    {
        public Occupation(string companyName, IAddress companyAddress, IPhone companyPhone)
            : base(companyName, companyAddress, companyPhone)
        {
        }
    }
}