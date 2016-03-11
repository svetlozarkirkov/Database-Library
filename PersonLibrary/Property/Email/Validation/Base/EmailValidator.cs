namespace PersonLibrary.Property.Email.Validation.Base
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    public class EmailValidator<T> : AbstractValidator<T> where T : IEmail
    {
        public EmailValidator()
        {
        }
    }
}