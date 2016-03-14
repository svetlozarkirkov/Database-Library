namespace TestConsoleApp
{
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Concrete;
    using PersonLibrary.Property.Address.Concrete;
    using PersonLibrary.Property.PersonInfo.Concrete;

    internal class App
    {
        private static void Main()
        {
            var personInfo = new PersonInfo("John", "Fokin", null, "12345670");
            var address = new Address("USA", "", "Johnny Cage 21", "1234");
            var instance = new MultipleEmailsPerson(personInfo);

            var validatorFactory = new AttributedValidatorFactory();

            //var personInfoValidator = validatorFactory.GetValidator(personInfo.GetType());
            //var addressValidator = validatorFactory.GetValidator(address.GetType());
            //var instanceValidator = validatorFactory.GetValidator(instance.GetType());

            //instanceValidator.Dump();
        }
    }
}