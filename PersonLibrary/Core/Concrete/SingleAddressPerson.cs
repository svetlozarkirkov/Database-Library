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
        public SingleAddressPerson(IPersonInfo personInfo, IAddress address)
            : base(personInfo)
        {
            this.Address = address;
        }

        public IAddress Address { get; set; }

        public override string ToString() => base.ToString() + "\nAddress: " + this.Address;
    }
}