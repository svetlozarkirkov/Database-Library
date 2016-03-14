namespace PersonLibrary.Core.Interface
{
    using PersonLibrary.Property.PersonInfo.Interface;

    public interface IPerson
    {
        IPersonInfo PersonInfo { get; }
    }
}