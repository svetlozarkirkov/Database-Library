namespace Person.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Email.Base;
    using Person.Property.Email.Validation.Interface;

    /// <summary>
    /// Class Email.
    /// </summary>
    /// <seealso cref="Person.Property.Email.Base.EmailBase" />
    /// TODO Edit XML Comment Template for Email
    [Validator(typeof(EmailInterfaceValidator))]
    public class Email : EmailBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email"/> class.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// TODO Edit XML Comment Template for #ctor
        public Email(string emailAddress) : base(emailAddress)
        {
        }
    }
}