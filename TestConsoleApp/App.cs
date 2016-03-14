namespace TestConsoleApp
{
    using System;
    using PersonLibrary.Core.Concrete;
    using PersonLibrary.Property.Address.Concrete;
    using PersonLibrary.Property.PersonInfo.Concrete;
    using PersonLibrary.Utilities.Validation;

    internal class App
    {
        private static void Main()
        {
            var personInfo = new PersonInfo("John", "Fokin", null, "12345670");
            var address = new Address("USA", "", "Johnny Cage 21", "1234");
            var instance = new Person(personInfo);

            var personInfoValidator = ValidationFactory.Instance.GetValidator(personInfo.GetType());
            var addressValidator = ValidationFactory.Instance.GetValidator(address.GetType());
            var instanceValidator = ValidationFactory.Instance.GetValidator(instance.GetType());

            var personInfoResults = personInfoValidator.Validate(personInfo);
            var addressResults = addressValidator.Validate(address);
            var instanceResults = instanceValidator.Validate(instance);

            foreach (var error in instanceResults.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}