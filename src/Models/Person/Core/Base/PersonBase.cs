namespace Person.Core.Base
{
    using FluentValidation.Attributes;
    using Person.Core.Contracts;
    using Person.Core.Validation.Contracts;
    using Person.Property.PrimaryInfo.Contracts;

    /// <summary>
    /// Class PersonBase.
    /// </summary>
    /// <seealso cref="IPerson" />
    [Validator(typeof(PersonInterfaceValidator))]
    public abstract class PersonBase : IPerson
    {
        protected PersonBase(IPrimaryInfo primaryInfo)
        {
            this.PrimaryInfo = primaryInfo;
        }

        /// <summary>
        /// Gets the primary information.
        /// </summary>
        /// <value>The primary information.</value>
        public IPrimaryInfo PrimaryInfo { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => this.PrimaryInfo.ToString();
    }
}