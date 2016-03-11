namespace PersonLibrary.Property.Occupation.Interface
{
    using PersonLibrary.Property.Address.Interface;

    public interface IOccupation
    {
        string CompanyName { get; set; }

        IAddress CompanyAddress { get; set; }
    }
}