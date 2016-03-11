namespace PersonLibrary.Property.Email.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    public class DotNetEmailValidator<T> : AbstractValidator<T> where T : IEmail
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