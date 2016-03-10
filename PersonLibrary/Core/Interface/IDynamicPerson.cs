namespace PersonLibrary.Core.Interface
{
    public interface IDynamicPerson
    {
        void AddProperty(string key, object value);

        void RemoveProperty(string key);
    }
}