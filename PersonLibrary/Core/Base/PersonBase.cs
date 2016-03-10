namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;
    using PersonLibrary.Core.Validation;

    /// <summary>
    /// Main Abstraction for PERSON
    /// </summary>
    [Validator(typeof(PersonValidator<IPerson>))]
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