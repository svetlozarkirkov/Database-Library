namespace PersonLibrary.Property.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Core.Interface;

    /// <summary>
    /// Class PropertyInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IProperty}" />
    public class PropertyInterfaceValidator : AbstractValidator<IProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInterfaceValidator"/> class.
        /// </summary>
        public PropertyInterfaceValidator()
        {
            this.RuleFor(prop => prop)
                .NotNull()
                .WithName("Property"); // Not L10N
        }
    }
}