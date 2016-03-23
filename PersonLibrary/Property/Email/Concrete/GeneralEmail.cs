namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    /// <summary>
    /// Class GeneralEmail.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Email.Base.EmailBase" />
    /// <seealso cref="PersonLibrary.Property.Email.Interface.IGeneralEmail" />
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