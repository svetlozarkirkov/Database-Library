namespace PersonLibrary.Property.Occupation.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.Occupation.Base;
    using PersonLibrary.Property.Occupation.Validation.Interface;
    using PersonLibrary.Property.Phone.Interface;

    /// <summary>
    /// Class Occupation.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.Occupation.Base.OccupationBase" />
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