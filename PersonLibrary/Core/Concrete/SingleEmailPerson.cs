namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(SingleEmailPersonValidator))]
    public class SingleEmailPerson : PersonBase, ISingleEmailPerson
    {
        public SingleEmailPerson(IPersonInfo personInfo, IEmail email) : base(personInfo)
        {
            this.Email = email;
        }

        public IEmail Email { get; set; }

        public override string ToString() => base.ToString() + "\nEmail: " + this.Email;
    }
}