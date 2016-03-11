namespace PersonLibrary.Property.Email.Base
{
    using PersonLibrary.Property.Email.Interface;

    /// <summary>
    /// Default abstraction for EMAIL
    /// </summary>
    public abstract class EmailBase : IEmail
    {
        protected EmailBase(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public string EmailAddress { get; set; }

        public override string ToString() => $"Email: [ {this.EmailAddress} ]";
    }
}