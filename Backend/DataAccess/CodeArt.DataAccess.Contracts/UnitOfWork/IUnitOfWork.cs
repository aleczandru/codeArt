using CodeArt.DataAccess.Contracts.DbContext.Models;
using CodeArt.DataAccess.Contracts.Repositories;

namespace CodeArt.DataAccess.Contracts.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<File> FileManagerRepository { get; }
        int SaveChanges();
    }
}
