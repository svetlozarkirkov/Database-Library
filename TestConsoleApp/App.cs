namespace TestConsoleApp
{
    using System;
    using System.Linq;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Concrete;
    using PersonLibrary.Property.Address.Concrete;
    using PersonLibrary.Property.Core;
    using PersonLibrary.Property.Email.Concrete;
    using PersonLibrary.Property.PrimaryInfo.Concrete;

    internal class App
    {
        private static void Main()
        {
            var person = new DynamicPerson();

            var address = new Address("", "New York", "Brooklyn St. 12", null);
            var primaryInfo = new PrimaryInfo("John", "", "Doe", "1234567890");
            var email = new GeneralEmail("@yahoo.com");

            person.AddProperty(PropertyType.Address, address);
            person.AddProperty(PropertyType.PrimaryInfo, primaryInfo);
            person.AddProperty(PropertyType.Email, null);

            Console.WriteLine(person);

            // validating each person property with its appropriate validator
            // and putting the results into a list
            var validatorFactory = new AttributedValidatorFactory();
            var combinedResults =
                (from prop in person.GetProperties()
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