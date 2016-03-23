namespace PersonLibrary.Property.Email.Validation.Concrete
{
    using System;
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;
    using PersonLibrary.Utilities.Validation;

    public class DotNetEmailValidator : CompositeValidator<IDotNetEmail>
    {
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"; // Not L10N

        /// <summary>
        /// Initializes a new instance of the <see cref="DotNetEmailValidator"/> class.
        /// </summary>
        /// <exception cref="NotSupportedException">Condition.</exception>
        public DotNetEmailValidator()
        {
            this.RegisterBaseValidator(new EmailInterfaceValidator());

            this.RuleFor(email => email.Email)
                .Matches(DotNetEmailRegex)
                .WithName("E-mail"); // Not L10N
        }
    }
}