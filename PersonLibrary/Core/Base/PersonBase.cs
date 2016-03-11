namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(PersonInterfaceValidator))]
    public abstract class PersonBase : IPerson
    {
        protected PersonBase(IPersonInfo personInfo)
        {
            this.PersonInfo = personInfo;
        }

        public IPersonInfo PersonInfo { get; }

        public override string ToString() => this.PersonInfo.ToString();
    }
}