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
        public SingleEmailPerson(IPersonInfo personInfo, IPersonGeneralEmail email)
            : base(personInfo)
        {
            this.Email = email;
        }

        public IPersonGeneralEmail Email { get; set; }

        public override string ToString() => base.ToString() + "\nEmail: " + this.Email;
    }
}