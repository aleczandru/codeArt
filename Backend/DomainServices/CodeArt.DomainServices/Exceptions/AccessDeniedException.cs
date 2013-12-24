namespace CodeArt.DomainServices.Exceptions
{
    public class AccessDeniedException : BaseException
    {
        public AccessDeniedException(string message , int statusCode)
            : base(message , statusCode)
        {
            
        }
    }
}
