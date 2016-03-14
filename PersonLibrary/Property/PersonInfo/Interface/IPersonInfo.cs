namespace PersonLibrary.Property.PersonInfo.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IPersonInfo : IProperty
    {
        string GetFirstName();

        string GetSurName();

        string GetLastName();

        string GetEgn();
    }
}