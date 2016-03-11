namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(PersonInterfaceValidator))]
    public class Person : PersonBase
    {
        public Person(IPersonInfo personInfo) : base(personInfo)
        {
        }
    }
}