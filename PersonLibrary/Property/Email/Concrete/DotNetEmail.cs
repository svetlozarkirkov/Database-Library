namespace PersonLibrary.Property.Email.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Email.Base;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Concrete;

    /// <summary>
    /// Class DotNetEmail.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Email.Base.EmailBase" />
    /// <seealso cref="PersonLibrary.Property.Email.Interface.IDotNetEmail" />
    [Validator(typeof(DotNetEmailValidator))]
    public class DotNetEmail : EmailBase, IDotNetEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DotNetEmail"/> class.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        public DotNetEmail(string emailAddress) : base(emailAddress)
        {
        }
    }
}