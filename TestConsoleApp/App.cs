using Person.Property.Occupation.Concrete;
using Person.Property.Phone.Concrete;

namespace TestConsoleApp
{
    using System;
    using System.Linq;
    using FluentValidation.Attributes;
    using Person.Core.Concrete;
    using Person.Property.Address.Concrete;
    using Person.Property.Email.Concrete;
    using Person.Property.PrimaryInfo.Concrete;

    internal class App
    {
        private static void Main()
        {
            var person = new DynamicPerson();

            var address = new Address(null, "New York", "Brooklyn St. 12", null);
            var primaryInfo = new PrimaryInfo("John", null, "Doe", "1234567890");
            var email = new Email("johndoe@yahoo.com");
            var occupation = new Occupation(
                "CIA",
                new Address("USA", "Langley", "Secret", "Secret"),
                new Phone("24162742")
            );

            person.AddProperty(address);
            person.AddProperty(primaryInfo);
            person.AddProperty(email);
            person.AddProperty(occupation);

            Console.WriteLine(person);

            // validating each person property with its appropriate validator
            // and putting the results into a list
            var validatorFactory = new AttributedValidatorFactory();
            var combinedResults =
                (from prop in person.Properties
                 let currentValidator = validatorFactory.GetValidator(prop.Value.GetType())
                 select currentValidator.Validate(prop.Value)).ToList();

            // iterating through the combined results and printing the errors (if any)
            foreach (var result in combinedResults)
            {
                var errors = result.Errors;

                foreach (var validationFailure in errors)
                {
                    Console.WriteLine(validationFailure);
                }
            }
        }
    }
}