namespace Person.Property.Occupation.Concrete
{
    using FluentValidation.Attributes;
    using Person.Property.Address.Contracts;
    using Person.Property.Occupation.Base;
    using Person.Property.Occupation.Validation.Contracts;
    using Person.Property.Phone.Contracts;

    /// <summary>
    /// Class Occupation.
    /// </summary>
    /// <seealso cref="OccupationBase" />
    [Validator(typeof(OccupationInterfaceValidator))]
    public class Occupation : OccupationBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Occupation"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="companyAddress">The company address.</param>
        /// <param name="companyPhone">The company phone.</param>
        public Occupation(string companyName, IAddress companyAddress, IPhone companyPhone)
            : base(companyName, companyAddress, companyPhone)
        {
        }
    }
}