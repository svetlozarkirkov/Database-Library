namespace Person.Core.Validation.Interface
{
    using FluentValidation;
    using Person.Core.Interface;
    using Person.Property.Core.Validation.Interface;

    /// <summary>
    /// Class DynamicPersonInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IDynamicPerson}" />
    public class DynamicPersonInterfaceValidator : AbstractValidator<IDynamicPerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPersonInterfaceValidator"/> class.
        /// </summary>
        public DynamicPersonInterfaceValidator()
        {
            this.RuleForEach(p => p.Properties.Keys)
                .NotNull()
                .WithName("Property type"); // Not L10N

            this.RuleFor(p => p.Properties.Values)
                .SetCollectionValidator(new PropertyInterfaceValidator());
        }
    }
}