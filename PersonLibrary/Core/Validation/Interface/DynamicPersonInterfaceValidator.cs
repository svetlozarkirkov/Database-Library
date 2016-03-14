namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class DynamicPersonInterfaceValidator : AbstractValidator<IDynamicPerson>
    {
        public DynamicPersonInterfaceValidator()
        {
            // TODO: iterate each property and validate it using its appropriate validator
        }
    }
}