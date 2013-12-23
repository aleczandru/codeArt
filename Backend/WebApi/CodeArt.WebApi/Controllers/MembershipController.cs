using System.Web.Http;
using CodeArt.Common.ExtensionMethods;
using CodeArt.DomainServices.Contracts.Models.Membership;
using CodeArt.WebApi.Attributes.ValidationAttribute;
using Microsoft.AspNet.Identity;

namespace CodeArt.WebApi.Controllers
{
    public class MembershipController : ApiController
    {
        private readonly UserManager<UserModel> userManager;
        private readonly UserValidator<UserModel> userValidator;

        public MembershipController(UserManager<UserModel> userManager, UserValidator<UserModel> userValidator)
        {
            this.userManager = userManager;
            this.userValidator = userValidator;
            ConfigureUserManager();
        }


        [AllowAnonymous]
        [HttpPost]
        [Validate]
        public IHttpActionResult Register(UserModel userRegistrationModel)
        {
            var userRegistrationResultModel = userManager.Create(userRegistrationModel,userRegistrationModel.Password);
            var errorResult = GetErrorResult(userRegistrationResultModel);

            if (errorResult.IsNotNull())
            {
                return errorResult;
            }

            return Ok();
        }

        private IHttpActionResult GetErrorResult(IdentityResult userRegistration)
        {
            if (userRegistration.IsNull())
            {
                return InternalServerError();
            }
            if (!userRegistration.Succeeded)
            {
                if (userRegistration.Errors.IsNotNull())
                {
                    foreach (var error in userRegistration.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
                return BadRequest();
            }
            return null;
        }

        private void ConfigureUserManager()
        {
            userValidator.AllowOnlyAlphanumericUserNames = false;
            userManager.UserValidator = userValidator;
        }
    }
}