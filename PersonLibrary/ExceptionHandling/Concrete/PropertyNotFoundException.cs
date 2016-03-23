namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Runtime.Serialization;

    /// <summary>
    /// </summary>
    [Serializable]
    public class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException()
        {
        }

        public PropertyNotFoundException(string message) : base(message)
        {
            Contract.Requires(message != null);
        }

        public PropertyNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
            Contract.Requires(message != null);
            Contract.Requires(innerException != null);
        }

        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected PropertyNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Contract.Requires(info != null);
        }
    }
}