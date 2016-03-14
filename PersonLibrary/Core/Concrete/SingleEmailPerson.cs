namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(SingleEmailPersonInterfaceValidator))]
    public class SingleEmailPerson : PersonBase, ISingleEmailPerson
    {
        private readonly IGeneralEmail _emailAddress;

        public SingleEmailPerson(IPersonInfo personInfo, IGeneralEmail email)
            : base(personInfo)
        {
            this._emailAddress = email;
        }

        public IGeneralEmail EmailAddress => this._emailAddress;

        public override string ToString() => base.ToString() + "\nEmail: " + this._emailAddress;
    }
}