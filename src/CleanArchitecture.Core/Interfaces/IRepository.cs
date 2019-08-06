using Medline.Recall.Core.SharedKernel;
using System.Collections.Generic;

namespace Medline.Recall.Core.Interfaces
{
    public interface IRepository//<TEntity>
    {
        T GetById<T>(int id) where T : BaseEntity;
        List<T> List<T>() where T : BaseEntity;
        T Add<T>(T entity) where T : BaseEntity;
        void Update<T>(T entity) where T : BaseEntity;
        void Delete<T>(T entity) where T : BaseEntity;

        //IEnumerable<TEntity> GetAll();

        //TEntity Get(long id);
        //void Add(TEntity entity);
        //void Update(Employee employee, TEntity entity);
        //void Delete(Employee employee);
    }
}
