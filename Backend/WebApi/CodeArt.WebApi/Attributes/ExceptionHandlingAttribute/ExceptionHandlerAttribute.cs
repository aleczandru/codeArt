using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using CodeArt.Common.ExtensionMethods;
using CodeArt.DomainServices.Exceptions;

namespace CodeArt.WebApi.Attributes.ExceptionHandlingAttribute
{
    class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        
        public override void OnException(HttpActionExecutedContext context)
        {
            var exception = context.Exception as BaseException;
            if (exception.IsNotNull())
            {
                context.Response = context.Request.CreateErrorResponse((HttpStatusCode)exception.ExceptionStatusCode,
                    GetHttpError(exception.ExceptionMessage));
            }
            else
            {
                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error");
            }
        }

        private HttpError GetHttpError(string message)
        {
            return new HttpError(message);
        }
    }
}
