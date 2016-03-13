namespace PersonLibrary.Core.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Core.Validation.Interface;

    [Validator(typeof(DynamicPersonInterfaceValidator))]
    public class DynamicPerson : DynamicPersonBase
    {
        public DynamicPerson() : base()
        {
        }
    }
}