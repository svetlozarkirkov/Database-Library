namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(PersonValidator<IPerson>))]
    public class Person : PersonBase
    {
        public Person(IPersonInfo personInfo)
            : base(personInfo)
        {
        }
    }
}