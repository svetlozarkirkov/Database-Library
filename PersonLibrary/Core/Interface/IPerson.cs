namespace PersonLibrary.Core.Interface
{
    using PersonLibrary.Property.PrimaryInfo.Interface;

    public interface IPerson
    {
        IPrimaryInfo PrimaryInfo { get; }
    }
}