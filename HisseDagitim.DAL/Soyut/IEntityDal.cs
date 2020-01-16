using HisseDagitim.Model.Somut;
using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.DAL.Soyut
{
    public interface IEntityDal<T> where T:EntityBase,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);


        T Get(Expression<Func<T, bool>> filter);


        void Add(T t_entity);


        void Update(T t_entity);


        void Delete(T t_entityt);
    }
}
