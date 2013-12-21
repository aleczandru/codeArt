using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DataAccess.Contracts.DbContext;
using CodeArt.DataAccess.Contracts.DbContext.Models;
using CodeArt.DataAccess.Contracts.Repositories;
using CodeArt.DataAccess.Contracts.UnitOfWork;
using CodeArt.DataAccess.Repositories;
using CodeArt.DataAccess.UnitOfWork;

namespace CodeArt.DataAccess.Config
{
    public static class DataAccessDependencyConfig
    {
        private static IDependencyContainerWrapper dependencyContainer;
        private static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as IDependencyContainerWrapper);
            }
        }

        public static void RegisterDataAccessDependencies()
        {
            DependencyContainer.RegisterType<IUnitOfWork, UnitofWork>();
            DependencyContainer.RegisterType<IRepository<File> , Repository<File>>();
            DependencyContainer.RegisterType<IDatabaseContext , DatabaseContext>();
        }
    }
}
