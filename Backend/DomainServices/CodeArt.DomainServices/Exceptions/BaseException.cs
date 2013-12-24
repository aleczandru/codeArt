using System;

namespace CodeArt.DomainServices.Exceptions
{
    public class BaseException : Exception
    {
        private readonly string message;
        private readonly int statusCode;

        public string ExceptionMessage
        {
            get
            {
                return message;
            }
        }

        public int ExceptionStatusCode
        {
            get
            {
                return statusCode;
            }
        }

        public BaseException(int statusCode, string message)
            : base(message)
        {
            this.message = message;
            this.statusCode = statusCode;
        }
    }
}
