namespace PersonLibrary.Property.Occupation.Interface
{
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Core.Interface;
    using PersonLibrary.Property.Phone.Interface;

    public interface IOccupation : IProperty
    {
        string CompanyName { get; }

        IAddress CompanyAddress { get; }

        IPhone CompanyPhone { get; }
    }
}