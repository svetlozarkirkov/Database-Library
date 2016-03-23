namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Validation.Interface;

    /// <summary>
    /// Class DynamicPerson.
    /// </summary>
    /// <seealso cref="PersonLibrary.Core.Base.DynamicPersonBase" />
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