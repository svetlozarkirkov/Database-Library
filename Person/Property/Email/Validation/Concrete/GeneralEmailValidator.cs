using System;
using FluentValidation;
using Person.Property.Email.Interface;
using Person.Property.Email.Validation.Interface;
using Person.Utilities.Validation;

namespace Person.Property.Email.Validation.Concrete
{
    /// <summary>
    /// Class GeneralEmailValidator.
    /// </summary>
    /// <seealso cref="Utilities.Validation.CompositeValidator{IGeneralEmail}" />
    public class GeneralEmailValidator : CompositeValidator<IGeneralEmail>
    {
        private const string GeneralEmailRegex =
            "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)" +
            "*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]" +
            "|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])" +
            "?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)" +
            "\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]" +
            ":(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[" +
            "\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])"; // Not L10N

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralEmailValidator"/> class.
        /// </summary>
        /// <exception cref="NotSupportedException">Condition.</exception>
        public GeneralEmailValidator()
        {
            this.RegisterBaseValidator(new EmailInterfaceValidator());

            this.RuleFor(email => email.Email)
                .Matches(GeneralEmailRegex)
                .WithName("E-mail"); // Not L10N
        }
    }
}