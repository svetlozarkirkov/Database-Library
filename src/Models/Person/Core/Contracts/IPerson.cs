namespace Person.Core.Contracts
{
    using Person.Property.PrimaryInfo.Contracts;

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