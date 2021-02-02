using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using OA.Data;

namespace OA.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        IEnumerable<T> GetAll();
        T GetByFilter(Expression<Func<T, bool>> filter);
        T get(long id);
        List<T> GetListByFilter(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
