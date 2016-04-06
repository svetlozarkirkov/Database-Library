﻿namespace Person.Core.Validation.Interface
{
    using FluentValidation;
    using Person.Core.Interface;
    using Person.Property.PrimaryInfo.Validation.Interface;

    /// <summary>
    /// Class PersonInterfaceValidator.
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{IPerson}" />
    public class PersonInterfaceValidator : AbstractValidator<IPerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInterfaceValidator"/> class.
        /// </summary>
        public PersonInterfaceValidator()
        {
            this.RuleFor(p => p.PrimaryInfo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .SetValidator(new PrimaryInfoInterfaceValidator())
                .WithName("Primary info"); // Not L10N
        }
    }
}