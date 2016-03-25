namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PrimaryInfo.Interface;

    /// <summary>
    /// Class PersonBase.
    /// </summary>
    /// <seealso cref="PersonLibrary.Core.Interface.IPerson" />
    [Validator(typeof(PersonInterfaceValidator))]
    public abstract class PersonBase : IPerson
    {
        protected internal PersonBase(IPrimaryInfo primaryInfo)
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