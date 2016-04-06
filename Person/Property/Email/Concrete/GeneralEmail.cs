namespace Person.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Email.Base;
    using Person.Property.Email.Interface;
    using Person.Property.Email.Validation.Concrete;

    /// <summary>
    /// Class GeneralEmail.
    /// </summary>
    /// <seealso cref="EmailBase" />
    /// <seealso cref="IGeneralEmail" />
    [Validator(typeof(GeneralEmailValidator))]
    public class GeneralEmail : EmailBase, IGeneralEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralEmail"/> class.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        public GeneralEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}