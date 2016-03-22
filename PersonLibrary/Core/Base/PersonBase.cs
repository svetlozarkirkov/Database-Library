namespace PersonLibrary.Core.Base
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.PrimaryInfo.Interface;

    [Validator(typeof(PersonInterfaceValidator))]
    public abstract class PersonBase : IPerson
    {
        protected PersonBase(IPrimaryInfo primaryInfo)
        {
            this.PrimaryInfo = primaryInfo;
        }

        public IPrimaryInfo PrimaryInfo { get; }

        public override string ToString() => this.PrimaryInfo.ToString();
    }
}