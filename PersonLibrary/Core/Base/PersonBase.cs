namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(PersonInterfaceValidator))]
    public abstract class PersonBase : IPerson
    {
        private readonly IPersonInfo _personInfo;

        protected PersonBase(IPersonInfo personInfo)
        {
            this._personInfo = personInfo;
        }
        public IPersonInfo PersonInfo => this._personInfo;

        public override string ToString() => this._personInfo.ToString();
    }
}