namespace PersonLibrary.Utilities.Validation
{
    using System;
    using FluentValidation;
    using Ninject;

    public class NinjectValidationFactory : ValidatorFactoryBase
    {
        private readonly IKernel _kernel;

        public NinjectValidationFactory()
        {
            this._kernel = new StandardKernel();
        }

        public override IValidator CreateInstance(Type validatorType) => this._kernel.Get(validatorType) as IValidator;
    }
}