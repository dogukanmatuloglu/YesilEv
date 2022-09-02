using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Contexts;
using YesilEv.Dal.Repositories.Abstract;

namespace YesilEv.Dal.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly YesilEvContext _context;
        public GenericRepository()
        {
            _context = new YesilEvContext();
        }
        public T Add(T entity)
        {
           _context.Set<T>().Add(entity);
            _context.SaveChanges();//burada savachanges demek yanlış gibi bir bak
            return entity;
        }

        public T Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
           var entityList= _context.Set<T>().ToList();
            return entityList;
        }

        public IEnumerable<T> GetByExpression(Func<T, bool> predicate) //burada tüm listeyi çekip filtreleme yapıyor galiba expression türü verirsen sql olarak filtreleme yapabilir araştır
        {
           return _context.Set<T>().Where(predicate);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Attach(entity);
            return entity;
        }
    }
}
