namespace PersonLibrary.Core.Validation.Interface
{
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class DynamicPersonInterfaceValidator : ValidatorSingletonBase<IDynamicPerson>
    {
        public DynamicPersonInterfaceValidator()
        {
            // TODO: iterate each property and validate it using its appropriate validator
        }
    }
}