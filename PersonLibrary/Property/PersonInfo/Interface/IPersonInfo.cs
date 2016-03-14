namespace PersonLibrary.Property.PersonInfo.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IPersonInfo : IProperty
    {
        string FirstName { get; }

        string MiddleName { get; }

        string LastName { get; }

        string Egn { get; }
    }
}