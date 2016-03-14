namespace PersonLibrary.Property.Address.Interface
{
    public interface IAddress
    {
        string GetCountry();

        string GetCity();

        string GetStreet();

        string GetPostCode();
    }
}