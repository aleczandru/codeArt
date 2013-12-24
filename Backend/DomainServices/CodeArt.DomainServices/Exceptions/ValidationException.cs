namespace CodeArt.DomainServices.Exceptions
{
    public class ValidationException : BaseException
    {
        public ValidationException(string message , int statusCode)
            : base(message , statusCode)
        {
            
        }
    }
}
