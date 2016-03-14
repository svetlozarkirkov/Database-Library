namespace PersonLibrary.Core.Interface
{
    using System.Collections.Generic;
    using PersonLibrary.Property.Email.Interface;

    public interface IMultipleEmailsPerson : IPerson
    {
        List<IGeneralEmail> EmailAddresses { get; }

        void AddEmailAddress(IGeneralEmail email);

        void RemoveEmailAddress(int index);
    }
}