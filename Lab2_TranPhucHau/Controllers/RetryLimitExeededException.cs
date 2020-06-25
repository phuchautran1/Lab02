using System;
using System.Runtime.Serialization;

namespace Lab2_TranPhucHau.Controllers
{
    [Serializable]
    internal class RetryLimitExeededException : Exception
    {
        public RetryLimitExeededException()
        {
        }

        public RetryLimitExeededException(string message) : base(message)
        {
        }

        public RetryLimitExeededException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetryLimitExeededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}