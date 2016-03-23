namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;
    using PersonLibrary.Property.Core.Validation.Interface;

    public class DynamicPersonInterfaceValidator : AbstractValidator<IDynamicPerson>
    {
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