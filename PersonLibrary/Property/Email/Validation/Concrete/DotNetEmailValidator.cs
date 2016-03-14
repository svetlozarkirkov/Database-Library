namespace PersonLibrary.Property.Email.Validation.Concrete
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;
    using PersonLibrary.Property.Email.Validation.Interface;
    using PersonLibrary.Utilities.Validation;


    internal class DotNetEmailValidator : CompositeValidator<IDotNetEmail>
    {
        /// <summary>
        /// Dot Net Email Regex
        /// </summary>
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        internal DotNetEmailValidator()
        {
            this.RegisterBaseValidator(new EmailInterfaceValidator());
            this.RuleFor(email => email.Email())
                .Matches(DotNetEmailRegex)
                .WithName("E-mail");
        }
    }
}