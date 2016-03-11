using PersonLibrary.Property.Address.Interface;

namespace PersonLibrary.Property.Occupation.Base
{
    using PersonLibrary.Property.Occupation.Interface;

    public abstract class OccupationBase : IOccupation
    {
        public string CompanyName { get; set; }
        public IAddress CompanyAddress { get; set; }
    }
}