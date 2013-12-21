using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CodeArt.DataAccess.Contracts.Repositories;

namespace CodeArt.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly DbContext dbContext;
        private IDbSet<T> dbSet;

        public IDbSet<T> DbSet
        {
            get
            {
                return dbSet ?? (dbSet = dbContext.Set<T>());
            }
        }

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateEntity(T entity)
        {
            DbSet.Add(entity);
        }

        public List<T> GetAllEntities()
        {
            return DbSet.ToList();
        }

        public T GetEntityById(int id)
        {
            return DbSet.Find(id);
        }

        public void EditEntity(T entity)
        {
            DbSet.AddOrUpdate(entity);
        }

        public void DeleteEntity(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}
