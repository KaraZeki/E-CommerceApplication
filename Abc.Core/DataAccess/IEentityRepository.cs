using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Core.DataAccess
{
    public interface IEentityRepository<T> where T:class, IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);  //Expression yapısı ile tüm sorguları parametre ile gönderebiliriz.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
