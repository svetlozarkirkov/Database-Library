namespace PersonLibrary.Property.Occupation.Interface
{
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Core.Interface;

    public interface IOccupation : IProperty
    {
        string GetCompanyName();

        IAddress GetCompanyAddress();
    }
}