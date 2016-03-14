namespace PersonLibrary.Property.PersonInfo.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PersonInfo.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    [Validator(typeof(PersonInfoInterfaceValidator))]
    public abstract class PersonInfoBase : IPersonInfo
    {
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;
        private readonly string _egn;

        protected PersonInfoBase(string firstName, string middleName, string lastName, string egn)
        {
            this._firstName = firstName;
            this._middleName = middleName;
            this._lastName = lastName;
            this._egn = egn;
        }

        public string FirstName => this._firstName;

        public string MiddleName => this._middleName;

        public string LastName => this._lastName;

        public string Egn => this._egn;

        public override string ToString() => $"Personal Info: {{ [ First name: {this._firstName} ] [ Middle name: {this._middleName} ] " +
            $"[ Last name: {this._lastName} ] [ EGN: {this._egn} ] }}";
    }
}