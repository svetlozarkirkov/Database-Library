namespace PersonLibrary.Property.Email.Concrete
{
    using PersonLibrary.Property.Email.Base;

    internal class GeneralEmail : EmailBase
    {
        protected GeneralEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}