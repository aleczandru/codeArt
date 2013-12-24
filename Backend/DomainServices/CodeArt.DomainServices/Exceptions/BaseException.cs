using System;

namespace CodeArt.DomainServices.Exceptions
{
    public class BaseException : Exception
    {
        private readonly string message;
        private readonly int statusCode;

        public int HttpStatusCode
        {
            get
            {
                return statusCode;
            }
        }

        public string ExceptionMessage
        {
            get
            {
                return message;
            }
        }

        public BaseException(string message, int statusCode)
            : base(message)
        {
            this.message = message;
            this.statusCode = statusCode;
        }


    }
}
