using System.Data.Entity;
using CodeArt.DataAccess.Contracts.DbContext.Models;

namespace CodeArt.DataAccess.Contracts.DbContext
{
    public interface IDatabaseContext
    {
        DbSet<File> Files { get; set; }
        DbSet<FileType> FileTypes { get; set; }
        int SaveChanges();
    }
}
