namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Core.Validation.Interface;
    using PersonLibrary.Property.Address.Interface;
    using PersonLibrary.Property.PersonInfo.Interface;

    [Validator(typeof(SingleAddressPersonInterfaceValidator))]
    public class SingleAddressPerson : PersonBase, ISingleAddressPerson
    {
        private readonly IAddress _address;

        public SingleAddressPerson(IPersonInfo personInfo, IAddress address)
            : base(personInfo)
        {
            this._address = address;
        }

        public IAddress GetAddress() => this._address;

        public override string ToString() => base.ToString() + "\nAddress: " + this._address;
    }
}