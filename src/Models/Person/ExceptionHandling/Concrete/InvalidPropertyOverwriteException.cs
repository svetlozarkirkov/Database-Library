namespace Person.ExceptionHandling.Concrete
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class InvalidPropertyOverwriteException.
    /// </summary>
    /// <seealso cref="System.InvalidOperationException" />
    [Serializable]
    public class InvalidPropertyOverwriteException : InvalidOperationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPropertyOverwriteException"/> class.
        /// </summary>
        internal InvalidPropertyOverwriteException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPropertyOverwriteException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        internal InvalidPropertyOverwriteException(string message) : base(message)
        {
            Contract.Requires(message != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPropertyOverwriteException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
        internal InvalidPropertyOverwriteException(string message, Exception innerException)
            : base(message, innerException)
        {
            Contract.Requires(message != null);
            Contract.Requires(innerException != null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPropertyOverwriteException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected internal InvalidPropertyOverwriteException
            (SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Contract.Requires(info != null);
        }
    }
}