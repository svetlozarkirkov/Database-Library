namespace Person.Core.Concrete
{
    using FluentValidation.Attributes;
    using Core.Base;
    using Core.Validation.Contracts;

    /// <summary>
    /// Class DynamicPerson.
    /// </summary>
    /// <seealso cref="DynamicPersonBase" />
    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public class DynamicPerson : DynamicPersonBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPerson"/> class.
        /// </summary>
        public DynamicPerson() : base()
        {
        }
    }
}