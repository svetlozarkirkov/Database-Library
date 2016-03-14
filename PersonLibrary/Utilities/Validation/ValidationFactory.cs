namespace PersonLibrary.Utilities.Validation
{
    using FluentValidation.Attributes;

    public class ValidationFactory
    {
        private static AttributedValidatorFactory _instance;

        private ValidationFactory() { }

#pragma warning disable CSE0003 // Use expression-bodied members
        public static AttributedValidatorFactory Instance
        {
            get
            {
                return _instance ?? (_instance = new AttributedValidatorFactory());
            }
        }
#pragma warning restore CSE0003 // Use expression-bodied members
    }
}