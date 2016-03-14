namespace PersonLibrary.Utilities.Validation
{
    using FluentValidation;

    internal class ValidatorSingletonBase<T> : AbstractValidator<T>
    {
        private static ValidatorSingletonBase<T> _instance;

        protected static ValidatorSingletonBase<T> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ValidatorSingletonBase<T>();
            }

            return _instance;
        }
    }
}