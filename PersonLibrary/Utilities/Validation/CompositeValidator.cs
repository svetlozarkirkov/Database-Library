namespace PersonLibrary.Utilities.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentValidation;
    using FluentValidation.Results;

    public abstract class CompositeValidator<T> : AbstractValidator<T>
    {
        private readonly List<IValidator> _additionalValidators = new List<IValidator>();

        /// <exception cref="NotSupportedException">Condition.</exception>
        protected void RegisterBaseValidator<TBase>(IValidator<TBase> validator)
        {
            // Ensure that we've registered a compatible validator.
            if (validator.CanValidateInstancesOfType(typeof(T)))
            {
                _additionalValidators.Add(validator);
            }
            else
            {
                throw new NotSupportedException(
                    $"Type {typeof (TBase).Name} is not a base-class or interface implemented by {typeof (T).Name}.");
            }
        }

        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var mainErrors = base.Validate(context).Errors;
            var errorsFromOtherValidators = _additionalValidators
                .SelectMany(x => x.Validate(context).Errors);

            var combinedErrors = mainErrors.Concat(errorsFromOtherValidators);
            return new ValidationResult(combinedErrors);
        }
    }
}