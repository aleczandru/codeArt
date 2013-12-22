using CodeArt.Common.Config;
using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DomainServices.Config;
using CodeArt.DomainServices.Contracts.Models.Membership;
using Microsoft.AspNet.Identity;

namespace CodeArt.WebApi.App_Start
{
     public static class DependencyConfig
     {

         private static IDependencyContainerWrapper dependencyContainer;

         public static IDependencyContainerWrapper DependencyContainer
         {
             get
             {
                 return dependencyContainer ?? (dependencyContainer =
                            HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as DependencyContainerWrapper);
             }
         }

        public static void RegisterDependencies()
        {
            DomainServicesDependencyConfig.RegisterDomainServicesDependencies();
            CommonDependencyConfig.RegisterCommonDependencies();
            RegisterWebApiDependencies();
        }

        private static void RegisterWebApiDependencies()
        {
            DependencyContainer.RegisterType<UserManager<UserModel>, UserManager<UserModel>>();
            DependencyContainer.RegisterType<UserValidator<UserModel>, UserValidator<UserModel>>();
        }
    }
}