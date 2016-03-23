namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class PropertyIsNullException.
    /// </summary>
    /// <seealso cref="System.ArgumentNullException" />
    [Serializable]
    public class PropertyIsNullException : ArgumentNullException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException"/> class.
        /// </summary>
        public PropertyIsNullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        public PropertyIsNullException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        public PropertyIsNullException(string paramName, string message)
            : base(paramName, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIsNullException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public PropertyIsNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected PropertyIsNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}