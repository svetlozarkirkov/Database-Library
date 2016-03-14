namespace PersonLibrary.Property.PersonInfo.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PersonInfo.Interface;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    [Validator(typeof(PersonInfoInterfaceValidator))]
    public abstract class PersonInfoBase : IPersonInfo
    {
        private readonly string _firstName;
        private readonly string _surName;
        private readonly string _lastName;
        private readonly string _egn;

        protected PersonInfoBase(string firstName, string surName, string lastName, string egn)
        {
            this._firstName = firstName;
            this._surName = surName;
            this._lastName = lastName;
            this._egn = egn;
        }

        public override string ToString() => $"Personal Info: {{ [ First name: {this._firstName} ] [ Surname: {this._surName} ] " +
            $"[ Last name: {this._lastName} ] [ EGN: {this._egn} ] }}";

        public string GetFirstName() => this._firstName;

        public string GetSurName() => this._surName;

        public string GetLastName() => this._lastName;

        public string GetEgn() => this._egn;
    }
}