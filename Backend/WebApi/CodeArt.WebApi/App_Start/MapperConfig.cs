using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.AutoMapper;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DomainServices.Config;

namespace CodeArt.WebApi.App_Start
{
    public static class MapperConfig
    {
        private static IDependencyContainerWrapper dependencyContainer;
        private static IMapperService mapperService;
        
        public static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as IDependencyContainerWrapper);
            }
        }

        public static IMapperService MapperService
        {
            get
            {
                return mapperService ?? (mapperService = DependencyContainer.Resolve<IMapperService>());
            }
        }

        public static void RegisterMappings()
        {
            DomainServicesMappingsConfig.RegisterDomainServicesMappings();
            MapperService.AssertConfigurationIsValid();
        }
    }
}
