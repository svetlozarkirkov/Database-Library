﻿namespace PersonLibrary.Property.Email.Validation.Concrete
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Utilities.Validation;

    internal class DotNetEmailValidator : ValidatorSingletonBase<IDotNetEmail>
    {
        /// <summary>
        /// Dot Net Email Regex
        /// </summary>
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        public DotNetEmailValidator()
        {
            this.RuleFor(email => email.Email())
                .Matches(DotNetEmailRegex)
                .WithName("E-mail");
        }
    }
}