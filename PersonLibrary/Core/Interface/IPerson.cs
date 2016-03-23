namespace PersonLibrary.Core.Interface
{
    using PersonLibrary.Property.PrimaryInfo.Interface;

    /// <summary>
    /// Interface IPerson
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets the primary information.
        /// </summary>
        /// <value>The primary information.</value>
        IPrimaryInfo PrimaryInfo { get; }
    }
}