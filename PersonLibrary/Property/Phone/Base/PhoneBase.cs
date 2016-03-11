namespace PersonLibrary.Property.Phone.Base
{
    using PersonLibrary.Property.Phone.Interface;

    public abstract class PhoneBase : IPhone
    {
        protected PhoneBase(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; set; }
    }
}