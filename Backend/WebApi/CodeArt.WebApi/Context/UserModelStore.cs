using CodeArt.Common.Constants;
using CodeArt.Common.Contracts.Wrappers;
using CodeArt.Common.Wrappers;
using CodeArt.DomainServices.Contracts.Models.Membership;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeArt.WebApi.Context
{
    public class UserModelStore : UserStore<UserModel>
    {
        private static IDependencyContainerWrapper dependencyContainer;
        private static DbContext dbContext;

        public static IDependencyContainerWrapper DependencyContainer
        {
            get
            {
                return dependencyContainer ?? (dependencyContainer =
                           HttpContextWrapper.Application[GeneralConstants.DEPENDENCY_CONTAINER_KEY] as DependencyContainerWrapper);
            }
        }

        public static DbContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = DependencyContainer.Resolve<IDbContext>() as DbContext);
            }
        }

        public UserModelStore() : base(DbContext)
        {
            
        }
    }
}