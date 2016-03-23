namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class PropertyTypeIsNullException.
    /// </summary>
    /// <seealso cref="System.ArgumentNullException" />
    [Serializable]
    public class PropertyTypeIsNullException : ArgumentNullException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTypeIsNullException"/> class.
        /// </summary>
        public PropertyTypeIsNullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTypeIsNullException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        public PropertyTypeIsNullException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTypeIsNullException"/> class.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        public PropertyTypeIsNullException(string paramName, string message)
            : base(paramName, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTypeIsNullException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public PropertyTypeIsNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected PropertyTypeIsNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}