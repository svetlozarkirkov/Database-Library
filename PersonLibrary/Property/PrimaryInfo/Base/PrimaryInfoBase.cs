namespace PersonLibrary.Property.PrimaryInfo.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PrimaryInfo.Interface;
    using PersonLibrary.Property.PrimaryInfo.Validation.Interface;

    [Validator(typeof(PrimaryInfoInterfaceValidator))]
    public abstract class PrimaryInfoBase : IPrimaryInfo
    {
        protected PrimaryInfoBase(string firstName, string middleName, string lastName, string egn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Egn = egn;
        }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public string Egn { get; }

        public override string ToString() => $"Primary Info: {{ [ First name: {this.FirstName} ] [ Middle name: {this.MiddleName} ] " +
            $"[ Last name: {this.LastName} ] [ EGN: {this.Egn} ] }}";
    }
}