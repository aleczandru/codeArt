﻿using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.AutoMapper;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;

namespace CodeArt.DataAccess.Config
{
    public static class DataAccessRegisterMappings
    {
        private static IMapperService mapperService;
        private static IDependencyContainerWrapper dependencyContainer;

        public static IMapperService MapperService
        {
            get
            {
                return mapperService ?? (mapperService = DependencyContainer.Resolve<IMapperService>());
            }
        }

        public static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as IDependencyContainerWrapper);
            }
        }

        public static void RegisterDataAccessMappings()
        {

        }
    }
}
