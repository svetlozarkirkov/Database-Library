namespace PersonLibrary.Property.PersonInfo.Base
{
    using PersonLibrary.Property.PersonInfo.Interface;

    public abstract class PersonInfoBase : IPersonInfo
    {
        protected PersonInfoBase(string firstName, string surName, string lastName, string egn)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.LastName = lastName;
            this.Egn = egn;
        }
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string LastName { get; set; }

        public string Egn { get; set; }

        public override string ToString() => $"Personal Info: {{ [ First name: {this.FirstName} ] [ Surname: {this.SurName} ] " +
            $"[ Last name: {this.LastName} ] [ EGN: {this.Egn} ] }}";
    }
}