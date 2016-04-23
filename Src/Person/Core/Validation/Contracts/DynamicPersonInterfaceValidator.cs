namespace Person.Core.Validation.Contracts
{
    using FluentValidation;
    using Person.Core.Contracts;
    using Person.Property.Core.Validation.Contracts;

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
                .WithName("Property type");

            this.RuleFor(p => p.Properties.Values)
                .SetCollectionValidator(new PropertyInterfaceValidator());
        }
    }
}