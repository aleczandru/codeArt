using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DataAccess.Config;
using CodeArt.DomainServices.Contracts.MembershipContext;
using CodeArt.DomainServices.Contracts.Models.Membership;
using CodeArt.DomainServices.MembershipContext;
using Microsoft.AspNet.Identity;

namespace CodeArt.DomainServices.Config
{
    public static class DomainServicesDependencyConfig
    {
        private static IDependencyContainerWrapper dependencyContainer;
        public static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as IDependencyContainerWrapper);
            }
        }

        public static void RegisterDomainServicesDependencies()
        {
            DataAccessDependencyConfig.RegisterDataAccessDependencies();
            DependencyContainer.RegisterSingletonType<IDbContext, DbContext>();
            DependencyContainer.RegisterType<IUserStore<UserModel>, UserModelStore>();

        }
    }
}
