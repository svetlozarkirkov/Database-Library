﻿namespace PersonLibrary.Property.PersonInfo.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.PersonInfo.Base;
    using PersonLibrary.Property.PersonInfo.Validation.Interface;

    [Validator(typeof(PersonInfoInterfaceValidator))]
    public class PersonInfo : PersonInfoBase
    {
        public PersonInfo(string firstName, string surName, string lastName, string egn)
            : base(firstName, surName, lastName, egn)
        {
        }
    }
}