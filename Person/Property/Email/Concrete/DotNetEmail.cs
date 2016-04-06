using FluentValidation.Attributes;
using Person.Property.Email.Base;
using Person.Property.Email.Interface;
using Person.Property.Email.Validation.Concrete;

namespace Person.Property.Email.Concrete
{
    /// <summary>
    /// Class DotNetEmail.
    /// </summary>
    /// <seealso cref="EmailBase" />
    /// <seealso cref="IDotNetEmail" />
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