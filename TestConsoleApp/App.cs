using System;
using FluentValidation.Attributes;
using PersonLibrary.Core.Concrete;
using PersonLibrary.Property.Address.Concrete;
using PersonLibrary.Property.PersonInfo.Concrete;

namespace TestConsoleApp
{
    internal class App
    {
        private static void Main()
        {
            var personInfo = new PersonInfo("John", "Fokin", "", "12345670");
            var address = new Address("USA", "", "Burjoazia 21", "1234");
            var instance = new SingleAddressPerson(personInfo, address);

            var validatorFactory = new AttributedValidatorFactory();

            var personInfoValidator = validatorFactory.GetValidator(personInfo.GetType());
            var addressValidator = validatorFactory.GetValidator(address.GetType());
            var instanceValidator = validatorFactory.GetValidator(instance.GetType());

            Console.WriteLine(personInfoValidator);
            Console.WriteLine(addressValidator);
            Console.WriteLine(instanceValidator);

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