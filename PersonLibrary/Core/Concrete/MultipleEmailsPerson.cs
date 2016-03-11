namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using System.Collections.Generic;
    using System.Text;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(MultipleEmailsPersonInterfaceValidator))]
    public class MultipleEmailsPerson : PersonBase, IMultipleEmailsPerson
    {
        public MultipleEmailsPerson(IPersonInfo personInfo) : base(personInfo)
        {
            this.Emails = new List<IGeneralEmail>();
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IGeneralEmail email)
            : base(personInfo)
        {
            this.Emails = new List<IGeneralEmail> { email };
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IEnumerable<IGeneralEmail> emails)
            : base(personInfo)
        {
            this.Emails = new List<IGeneralEmail>();
            ((List<IGeneralEmail>)this.Emails).AddRange(emails);
        }

        public IEnumerable<IGeneralEmail> Emails { get; }

        public void AddEmail(IGeneralEmail email)
        {
            ((List<IGeneralEmail>)this.Emails).Add(email);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nEmails: { ");
            foreach (var address in Emails)
            {
                result.Append(address);
            }
            result.Append(" }");
            return base.ToString() + result;
        }
    }
}