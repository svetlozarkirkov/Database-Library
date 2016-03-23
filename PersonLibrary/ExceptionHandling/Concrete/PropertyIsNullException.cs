namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// </summary>
    [Serializable]
    public class PropertyIsNullException : ArgumentNullException
    {
        public PropertyIsNullException()
        {
        }

        public PropertyIsNullException(string paramName) : base(paramName)
        {
        }

        public PropertyIsNullException(string paramName, string message)
            : base(paramName, message)
        {
        }

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