namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using System.Collections.Generic;
    using System.Text;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(MultipleAddressPersonValidator))]
    public class MultipleAddressesPerson : PersonBase, IMultipleAddressesPerson
    {
        public MultipleAddressesPerson(IPersonInfo personInfo) : base(personInfo)
        {
            this.Addresses = new List<IAddress>();
        }

        public MultipleAddressesPerson(IPersonInfo personInfo, IAddress address) : base(personInfo)
        {
            this.Addresses = new List<IAddress> { address };
        }

        public MultipleAddressesPerson
            (IPersonInfo personInfo, IEnumerable<IAddress> addresses) : base(personInfo)
        {
            this.Addresses = new List<IAddress>();
            ((List<IAddress>)this.Addresses).AddRange(addresses);
        }

        public IEnumerable<IAddress> Addresses { get; }

        public void AddAddress(IAddress address)
        {
            ((List<IAddress>)this.Addresses).Add(address);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nAddresses: { ");
            foreach (var address in Addresses)
            {
                result.Append(address);
            }
            result.Append(" }");
            return base.ToString() + result;
        }
    }
}