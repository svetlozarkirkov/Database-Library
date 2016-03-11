namespace PersonLibrary.Property.Email.Validation.Concrete
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Concrete;
    using PersonLibrary.Property.Email.Validation.Base;

    public class DotNetEmailValidator : EmailValidator<DotNetEmail>
    {
        /// <summary>
        /// Dot Net Email Regex
        /// </summary>
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        public DotNetEmailValidator()
        {
            this.RuleFor(email => email.EmailAddress).NotNull().Matches(DotNetEmailRegex);
        }
    }
}