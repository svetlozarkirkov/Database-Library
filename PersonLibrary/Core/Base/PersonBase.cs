namespace PersonLibrary.Core.Base
{
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    /// <summary>
    /// Main Abstraction for PERSON
    /// </summary>
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