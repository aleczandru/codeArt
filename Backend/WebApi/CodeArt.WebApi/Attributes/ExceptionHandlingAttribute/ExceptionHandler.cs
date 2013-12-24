using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.ExtensionMethods;
using CodeArt.Common.Wrappers;
using CodeArt.DomainServices.Exceptions;

namespace CodeArt.WebApi.Attributes.ExceptionHandlingAttribute
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        private IDependencyContainerWrapper dependencyContainer;

        public IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as DependencyContainerWrapper);
            }
        }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response != null)
            {
                actionExecutedContext.Response.Dispose();
            }

            var baseException = actionExecutedContext.Exception as BaseException;

            if (baseException.IsNotNull())
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse((HttpStatusCode)baseException.HttpStatusCode, BuildHttpError(baseException.Message));
            }
            else
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, "An error has occurd please come back later!");
            }
        }

        private HttpError BuildHttpError(string message)
        {
            return new HttpError{{"Message" , message}};
        }
    }
}