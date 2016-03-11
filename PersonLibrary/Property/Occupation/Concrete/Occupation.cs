namespace PersonLibrary.Property.Occupation.Concrete
{
    using FluentValidation.Attributes;
    using PersonLibrary.Property.Occupation.Base;
    using PersonLibrary.Property.Occupation.Validation.Interface;

    [Validator(typeof(OccupationInterfaceValidator))]
    public class Occupation : OccupationBase
    {

    }
}