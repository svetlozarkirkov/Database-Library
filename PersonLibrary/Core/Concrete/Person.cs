namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PrimaryInfo.Interface;

    /// <summary>
    /// Class Person.
    /// </summary>
    /// <seealso cref="PersonLibrary.Core.Base.PersonBase" />
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