namespace PersonLibrary.Property.PersonInfo.Concrete
{
    using PersonLibrary.Property.PersonInfo.Base;

    internal class PersonInfo : PersonInfoBase
    {
        public PersonInfo(string firstName, string surName, string lastName, string egn)
            : base(firstName, surName, lastName, egn)
        {
        }
    }
}