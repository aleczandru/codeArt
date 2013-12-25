using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DataAccess.Config;

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
            

        }
    }
}
