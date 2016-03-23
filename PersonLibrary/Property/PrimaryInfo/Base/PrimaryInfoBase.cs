namespace PersonLibrary.Property.PrimaryInfo.Base
{
    using System.Diagnostics.Contracts;
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PrimaryInfo.Interface;
    using PersonLibrary.Property.PrimaryInfo.Validation.Interface;

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

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public string Egn { get; }

        public override string ToString() => $"Primary Info: {{ [ First name: {this.FirstName} ] [ Middle name: {this.MiddleName} ] " +
            $"[ Last name: {this.LastName} ] [ EGN: {this.Egn} ] }}";
    }
}