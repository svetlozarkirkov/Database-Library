namespace Person.ExceptionHandling.Concrete
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class PropertyNotFoundException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class PropertyNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNotFoundException" /> class.
        /// </summary>
        internal PropertyNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        internal PropertyNotFoundException(string message) : base(message)
        {
            Contract.Requires(message != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        internal PropertyNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
            Contract.Requires(message != null);
            Contract.Requires(innerException != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyNotFoundException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
        protected internal PropertyNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Contract.Requires(info != null);
        }
    }
}