namespace PersonLibrary.Property.PrimaryInfo.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IPrimaryInfo : IProperty
    {
        string FirstName { get; }

        string MiddleName { get; }

        string LastName { get; }

        string Egn { get; }
    }
}