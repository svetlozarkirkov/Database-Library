namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    internal class DynamicPersonInterfaceValidator : AbstractValidator<IDynamicPerson>
    {
        internal DynamicPersonInterfaceValidator()
        {
            // TODO: iterate each property and validate it using its appropriate validator
        }
    }
}