namespace PersonLibrary.Property.Phone.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IPhone : IProperty
    {
        string PhoneNumber { get; }
    }
}