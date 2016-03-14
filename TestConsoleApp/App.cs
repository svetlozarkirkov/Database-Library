namespace TestConsoleApp
{
    using FluentValidation.Attributes;
    using System;
    using PersonLibrary.Core.Concrete;
    using PersonLibrary.Property.PersonInfo.Concrete;

    internal class App
    {
        private static void Main()
        {
            PersonInfo personInfo = null;
            var instance = new Person(personInfo);
            var validator = new AttributedValidatorFactory().GetValidator(instance.GetType());
            var results = validator.Validate(instance);
            foreach (var error in results.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}