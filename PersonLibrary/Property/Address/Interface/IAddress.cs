namespace PersonLibrary.Property.Address.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IAddress : IProperty
    {
        string GetCountry();

        string GetCity();

        string GetStreet();

        string GetPostCode();
    }
}