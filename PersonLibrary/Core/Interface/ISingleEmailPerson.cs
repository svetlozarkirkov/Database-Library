namespace PersonLibrary.Core.Interface
{
    using PersonLibrary.Property.Email.Interface;

    public interface ISingleEmailPerson : IPerson
    {
        IEmail Email { get; set; }
    }
}