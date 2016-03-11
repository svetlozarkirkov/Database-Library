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
            this.Emails = new List<IPersonGeneralEmail>();
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IPersonGeneralEmail email)
            : base(personInfo)
        {
            this.Emails = new List<IPersonGeneralEmail> { email };
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IEnumerable<IPersonGeneralEmail> emails)
            : base(personInfo)
        {
            this.Emails = new List<IPersonGeneralEmail>();
            ((List<IPersonGeneralEmail>)this.Emails).AddRange(emails);
        }

        public IEnumerable<IPersonGeneralEmail> Emails { get; }

        public void AddEmail(IPersonGeneralEmail email)
        {
            ((List<IPersonGeneralEmail>)this.Emails).Add(email);
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