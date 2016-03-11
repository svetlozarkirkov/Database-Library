﻿namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Email.Interface;

    public interface IMultipleEmailsPerson : IPerson
    {
        IEnumerable<IGeneralEmail> Emails { get; }
    }
}