using CodeArt.Common.AutoMapper;
using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.AutoMapper;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;

namespace CodeArt.Common.Config
{
    public static class CommonDependencyConfig
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

        public static void RegisterCommonDependencies()
        {
            DependencyContainer.RegisterType<IHttpContextWrapper , HttpContextWrapper>();
            DependencyContainer.RegisterType<IMapperService , MapperService>();
        }
    }
}
