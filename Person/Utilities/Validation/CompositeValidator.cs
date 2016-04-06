namespace Person.Utilities.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentValidation;
    using FluentValidation.Results;

    /// <summary>
    /// Class CompositeValidator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="FluentValidation.AbstractValidator{T}" />
    public abstract class CompositeValidator<T> : AbstractValidator<T>
    {
        private readonly List<IValidator> _additionalValidators = new List<IValidator>();

        /// <summary>
        /// Registers the base validator.
        /// </summary>
        /// <typeparam name="TBase">The type of the t base.</typeparam>
        /// <param name="validator">The validator.</param>
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

        /// <summary>
        /// Validates the specified instance.
        /// </summary>
        /// <param name="context">Validation Context</param>
        /// <returns>A ValidationResult object containing any validation failures.</returns>
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