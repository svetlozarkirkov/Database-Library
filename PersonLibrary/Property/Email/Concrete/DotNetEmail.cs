namespace PersonLibrary.Property.Email.Concrete
{
    using PersonLibrary.Property.Email.Base;

    internal class DotNetEmail : EmailBase
    {
        protected DotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}