namespace PersonLibrary.Property.Email.Concrete
{
    using PersonLibrary.Property.Email.Base;

    public class DotNetEmail : EmailBase
    {
        public DotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}