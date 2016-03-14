namespace TestConsoleApp
{
    using System;
    using FluentValidation.Attributes;
    using PersonLibrary.Core.Concrete;
    using PersonLibrary.Property.Address.Concrete;
    using PersonLibrary.Property.Email.Concrete;
    using PersonLibrary.Property.Occupation.Concrete;
    using PersonLibrary.Property.PersonInfo.Concrete;

    internal class App
    {
        private static void Main()
        {
            var personInfo = new PersonInfo("", "Foker", "Doe", "567890");
            var address = new Address("Bulgaria", "Sofia", "UNKNOWN", null);
            var occupation = new Occupation("", address);

            var person =
                new MultipleAddressesPerson(personInfo, address);

            var validator = new AttributedValidatorFactory().GetValidator(person.GetType());
            Console.WriteLine(validator.GetType().FullName);
            var results = validator.Validate(person);
            foreach (var error in results.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}