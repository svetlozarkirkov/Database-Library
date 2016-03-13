﻿namespace PersonLibrary.Property.Email.Validation.Concrete
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;
    using PersonLibrary.Utilities.Validation;


    public class DotNetEmailValidator : CompositeValidator<IDotNetEmail>
    {
        /// <summary>
        /// Dot Net Email Regex
        /// </summary>
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        public DotNetEmailValidator()
        {
            this.RegisterBaseValidator(new EmailInterfaceValidator());
            this.RuleFor(email => email.EmailAddress).Matches(DotNetEmailRegex);
        }
    }
}