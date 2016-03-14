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
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(MultipleAddressesPersonInterfaceValidator))]
    public class MultipleAddressesPerson : PersonBase, IMultipleAddressesPerson
    {
        private readonly List<IAddress> _addresses;

        public MultipleAddressesPerson(IPersonInfo personInfo) : base(personInfo)
        {
            this._addresses = new List<IAddress>();
        }

        public MultipleAddressesPerson(IPersonInfo personInfo, IAddress address) : base(personInfo)
        {
            this._addresses = new List<IAddress> { address };
        }

        public MultipleAddressesPerson
            (IPersonInfo personInfo, IEnumerable<IAddress> addresses) : base(personInfo)
        {
            this._addresses = new List<IAddress>();
            this._addresses.AddRange(addresses);
        }

        public List<IAddress> Addresses => this._addresses.ToList();

        public void AddAddress(IAddress address)
        {
            this._addresses.Add(address);
        }

        public void RemoveAddress(int index)
        {
            if (index >= 0 && index < this._addresses.Count)
            {
                this._addresses.RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Cannot remove address - invalid index given.");
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nAddresses: { ");
            foreach (var address in _addresses)
            {
                result.Append(address);
            }
            result.Append(" }");
            return base.ToString() + result;
        }
    }
}