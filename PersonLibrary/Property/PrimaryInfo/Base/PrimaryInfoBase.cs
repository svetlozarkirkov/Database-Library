namespace PersonLibrary.Property.PrimaryInfo.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PrimaryInfo.Interface;
    using PersonLibrary.Property.PrimaryInfo.Validation.Interface;

    /// <summary>
    /// Class PrimaryInfoBase.
    /// </summary>
    /// <seealso cref="PersonLibrary.Property.PrimaryInfo.Interface.IPrimaryInfo" />
    [Validator(typeof(PrimaryInfoInterfaceValidator))]
    public abstract class PrimaryInfoBase : IPrimaryInfo
    {
        protected PrimaryInfoBase(string firstName, string middleName, string lastName, string egn)
        {
            Contract.Requires(firstName != null);
            Contract.Requires(middleName != null);
            Contract.Requires(lastName != null);
            Contract.Requires(egn != null);
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Egn = egn;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(FirstName != null);
            Contract.Invariant(MiddleName != null);
            Contract.Invariant(LastName != null);
            Contract.Invariant(Egn != null);
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; }

        /// <summary>
        /// Gets the middle name.
        /// </summary>
        /// <value>The middle name.</value>
        public string MiddleName { get; }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; }

        /// <summary>
        /// Gets the egn.
        /// </summary>
        /// <value>The egn.</value>
        public string Egn { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => $"Primary Info: {{ [ First name: {this.FirstName} ] [ Middle name: {this.MiddleName} ] " +
            $"[ Last name: {this.LastName} ] [ EGN: {this.Egn} ] }}";
    }
}