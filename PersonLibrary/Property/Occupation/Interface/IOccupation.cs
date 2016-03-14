namespace PersonLibrary.Property.Occupation.Interface
{
    using PersonLibrary.Property.Address.Interface;

    public interface IOccupation
    {
        string GetCompanyName();

        IAddress GetCompanyAddress();
    }
}