namespace PersonLibrary.Property.PrimaryInfo.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PrimaryInfo.Base;
    using PersonLibrary.Property.PrimaryInfo.Validation.Interface;

    [Validator(typeof(PrimaryInfoInterfaceValidator))]
    public class PrimaryInfo : PrimaryInfoBase
    {
        public PrimaryInfo(string firstName, string middleName, string lastName, string egn)
            : base(firstName, middleName, lastName, egn)
        {
        }
    }
}