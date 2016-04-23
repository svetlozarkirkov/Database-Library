namespace Person.Property.PrimaryInfo.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.PrimaryInfo.Base;
    using Person.Property.PrimaryInfo.Validation.Contracts;

    /// <summary>
    /// Class PrimaryInfo.
    /// </summary>
    /// <seealso cref="PrimaryInfoBase" />
    [Validator(typeof(PrimaryInfoInterfaceValidator))]
    public class PrimaryInfo : PrimaryInfoBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryInfo"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="middleName">The middle name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="egn">The egn.</param>
        public PrimaryInfo(string firstName, string middleName, string lastName, string egn)
            : base(firstName, middleName, lastName, egn)
        {
        }
    }
}