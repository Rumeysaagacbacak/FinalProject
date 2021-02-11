using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class :Referans tip olaabilir.
    //IENtity olabilir veya IEntity implemeente eden bir nesene olabilir.
    //new(): new'lenebilir olmalı
    public  interface IEntityRepository<T> where T:class,IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null); //başka yerde listelediğimiz filtreleri burada kullanılır.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
