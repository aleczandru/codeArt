using System.Collections.Generic;

namespace CodeArt.DataAccess.Contracts.Repositories
{
    public interface IRepository<T>
    {
        void CreateEntity(T entity);
        List<T> GetAllEntities();
        T GetEntityById(int id);
        void EditEntity(T entity);
        void DeleteEntity(T entity);
    }
}
