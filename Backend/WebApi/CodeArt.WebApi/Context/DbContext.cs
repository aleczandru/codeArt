using CodeArt.DomainServices.Contracts.Models.Membership;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeArt.WebApi.Context
{
    public class DbContext : IdentityDbContext<UserModel>, IDbContext
    {
        public DbContext()
            : base("CodeArtConnectionString")
        {
            
        }
    }
}