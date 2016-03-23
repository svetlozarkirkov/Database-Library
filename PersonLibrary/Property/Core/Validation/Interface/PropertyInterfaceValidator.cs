namespace PersonLibrary.Property.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Core.Interface;

    public class PropertyInterfaceValidator : AbstractValidator<IProperty>
    {
        public PropertyInterfaceValidator()
        {
            this.RuleFor(prop => prop)
                .NotNull()
                .WithName("Property"); // Not L10N
        }
    }
}