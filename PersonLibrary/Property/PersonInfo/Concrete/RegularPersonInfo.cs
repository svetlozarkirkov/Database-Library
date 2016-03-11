namespace PersonLibrary.Property.PersonInfo.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PersonInfo.Base;
    using PersonLibrary.Property.PersonInfo.Validation.Concrete;

    [Validator(typeof(RegularPersonInfoValidator))]
    public class RegularPersonInfo : PersonInfoBase
    {
        public RegularPersonInfo(string firstName, string surName, string lastName, string egn)
            : base(firstName, surName, lastName, egn)
        {
        }
    }
}