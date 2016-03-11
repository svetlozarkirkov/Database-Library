namespace PersonLibrary.Property.Occupation.Validation.Base
{
    using FluentValidation;
    using PersonLibrary.Property.Occupation.Interface;

    public class OccupationValidator<T> : AbstractValidator<T> where T : IOccupation
    {
        public OccupationValidator()
        {
        }
    }
}