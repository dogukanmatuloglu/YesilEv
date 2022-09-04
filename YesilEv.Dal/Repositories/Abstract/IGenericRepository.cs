using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEv.Dal.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
         T GetById(int id);
         IEnumerable<T> GetAll(); 
         IEnumerable<T> GetByExpression(Func<T, bool> predicate);
         T Add(T entity);
         T Update(T entity);
         T Delete(T entity);

    }
}
