namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class PropertyIsNullException.
    /// </summary>
    /// <seealso cref="System.ArgumentNullException" />
    [Serializable]
    public class PropertyIsNullException : ArgumentNullException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException" /> class.
        /// </summary>
        internal PropertyIsNullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException" /> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        internal PropertyIsNullException(string paramName) : base(paramName)
        {
            Contract.Requires(paramName != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException" /> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        internal PropertyIsNullException(string paramName, string message)
            : base(paramName, message)
        {
            Contract.Requires(paramName != null);
            Contract.Requires(message != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        internal PropertyIsNullException(string message, Exception innerException)
            : base(message, innerException)
        {
            Contract.Requires(message != null);
            Contract.Requires(innerException != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">An object that describes the source or destination of the serialized data.</param>
        protected internal PropertyIsNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Contract.Requires(info != null);
        }
    }
}