using Core.Entities; 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Aşağıdaki Expression işlemi filtrelemeye yarar eşit null olursa filtre vermedende bilgileri getirir ancak null vermezsek bir filtre vermek zorunda kalırız
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
