namespace PersonLibrary.Property.Email.Concrete
{
    using PersonLibrary.Property.Email.Base;

    /// <summary>
    /// Base concrete implementation for EMAIL
    /// </summary>
    internal class Email : EmailBase
    {
        protected Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}