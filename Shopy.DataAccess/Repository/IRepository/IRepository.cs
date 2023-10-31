using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopy.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        //T - Category
        IEnumerable<T> GetAll(string? includeProperties = null); //Get all Categories
        T GetFirstOrDefault(Expression<Func<T,bool>>filter, string? includeProperties = null); // get one Category
        //T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity); 
        void RemoveRange(IEnumerable<T> entities);
    }
}
