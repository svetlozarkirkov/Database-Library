namespace PersonLibrary.Property.Occupation.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Property.Occupation.Interface;

    public class OccupationInterfaceValidator : AbstractValidator<IOccupation>
    {
        public OccupationInterfaceValidator()
        {
        }
    }
}