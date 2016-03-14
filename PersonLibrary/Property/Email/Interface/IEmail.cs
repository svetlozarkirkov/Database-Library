namespace PersonLibrary.Property.Email.Interface
{
    using PersonLibrary.Property.Core.Interface;

    public interface IEmail : IProperty
    {
        string Email { get; }
    }
}