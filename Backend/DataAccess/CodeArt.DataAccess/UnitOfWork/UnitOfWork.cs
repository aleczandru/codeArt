using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DataAccess.Contracts.DbContext;
using CodeArt.DataAccess.Contracts.DbContext.Models;
using CodeArt.DataAccess.Contracts.Repositories;
using CodeArt.DataAccess.Contracts.UnitOfWork;

namespace CodeArt.DataAccess.UnitOfWork
{
    public class UnitofWork : IUnitOfWork
    {
        private IDependencyContainerWrapper dependencyContainer;
        private IRepository<File> fileManageRepository;
        private readonly IDatabaseContext databaseContext;

        public IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer = HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as IDependencyContainerWrapper);
            }
        }

        public IRepository<File> FileManagerRepository
        {
            get
            {
                return fileManageRepository ?? (fileManageRepository = DependencyContainer.Resolve<IRepository<File>>());
            }
        }

        public UnitofWork(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public int SaveChanges()
        {
           return databaseContext.SaveChanges();
        }
    }
}
