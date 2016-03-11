namespace PersonLibrary.Property.Email.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    public class DotNetEmailValidator : EmailValidator<IEmail>
    {
        /// <summary>
        /// Dot Net Email Regex
        /// </summary>
        private const string DotNetEmailRegex =
            "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        public DotNetEmailValidator()
        {
            RuleFor(email => email.EmailAddress).NotNull().Matches(DotNetEmailRegex);
        }
    }
}