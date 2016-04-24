namespace Person.Property.Core.Validation.Contracts
{
    using FluentValidation;
    using Person.Property.Core.Contracts;

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
                .WithName("Property");
        }
    }
}