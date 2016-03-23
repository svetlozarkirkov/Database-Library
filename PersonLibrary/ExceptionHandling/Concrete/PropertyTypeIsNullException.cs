namespace PersonLibrary.ExceptionHandling.Concrete
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// </summary>
    [Serializable]
    public class PropertyTypeIsNullException : ArgumentNullException
    {
        public PropertyTypeIsNullException()
        {
        }

        public PropertyTypeIsNullException(string paramName) : base(paramName)
        {
        }

        public PropertyTypeIsNullException(string paramName, string message)
            : base(paramName, message)
        {
        }

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