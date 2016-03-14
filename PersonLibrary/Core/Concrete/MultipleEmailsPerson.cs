namespace PersonLibrary.Core.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(MultipleEmailsPersonInterfaceValidator))]
    public class MultipleEmailsPerson : PersonBase, IMultipleEmailsPerson
    {
        private readonly List<IGeneralEmail> _emailAddresses;

        public MultipleEmailsPerson(IPersonInfo personInfo) : base(personInfo)
        {
            this._emailAddresses = new List<IGeneralEmail>();
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IGeneralEmail email)
            : base(personInfo)
        {
            this._emailAddresses = new List<IGeneralEmail> { email };
        }

        public MultipleEmailsPerson(IPersonInfo personInfo, IEnumerable<IGeneralEmail> emails)
            : base(personInfo)
        {
            this._emailAddresses = new List<IGeneralEmail>();
            this._emailAddresses.AddRange(emails);
        }

        public List<IGeneralEmail> EmailAddresses => this._emailAddresses.ToList();

        public void AddEmailAddress(IGeneralEmail email)
        {
            this._emailAddresses.Add(email);
        }

        public void RemoveEmailAddress(int index)
        {
            if (index >= 0 && index < this._emailAddresses.Count)
            {
                this._emailAddresses.RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Cannot remove e-mail - invalid index given");
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nEmails: { ");
            foreach (var address in this._emailAddresses)
            {
                result.Append(address);
            }
            result.Append(" }");
            return base.ToString() + result;
        }
    }
}