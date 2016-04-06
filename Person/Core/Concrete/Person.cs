namespace Person.Core.Concrete
{
    using FluentValidation.Attributes;
    using Core.Base;
    using Core.Validation.Interface;
    using Property.PrimaryInfo.Interface;

    /// <summary>
    /// Class Person.
    /// </summary>
    /// <seealso cref="PersonBase" />
    [Validator(typeof(PersonInterfaceValidator))]
    public class Person : PersonBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="primaryInfo">The primary information.</param>
        public Person(IPrimaryInfo primaryInfo) : base(primaryInfo)
        {
        }
    }
}