namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using System.Collections.Generic;
    using System.Text;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(MultipleEmailsPersonValidator))]
    public class MultipleEmailsPerson : PersonBase, IMultipleEmailsPerson
    {
        public MultipleEmailsPerson(IPersonInfo personInfo) : base(personInfo)
        {
            this.Emails = new List<IEmail>();
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IEmail email) : base(personInfo)
        {
            this.Emails = new List<IEmail> { email };
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IEnumerable<IEmail> emails)
            : base(personInfo)
        {
            this.Emails = new List<IEmail>();
            ((List<IEmail>)this.Emails).AddRange(emails);
        }

        public IEnumerable<IEmail> Emails { get; }

        public void AddEmail(IEmail email)
        {
            ((List<IEmail>)this.Emails).Add(email);
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