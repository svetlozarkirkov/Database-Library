namespace PersonLibrary.Property.Phone.Validation.Base
{
    using FluentValidation;
    using PersonLibrary.Property.Phone.Interface;

    public class PhoneValidator<T> : AbstractValidator<T> where T : IPhone
    {
    }
}