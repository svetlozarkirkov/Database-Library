namespace PersonLibrary.Property.Email.Validation
{
    using FluentValidation;
    using PersonLibrary.Property.Email.Interface;

    public abstract class EmailValidator<T> : AbstractValidator<T> where T : IEmail
    {
        protected EmailValidator()
        {
        }
    }
}