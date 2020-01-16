using HisseDagitim.DAL.Soyut;
using HisseDagitim.Model.Somut;
using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.DAL.Somut.EntityFramework
{
    public class EfEntityDal<TEntity, TContext> : IEntityDal<TEntity> where TEntity:EntityBase,IEntity,new() where TContext:DbContext,new()
    {
        public void Add(TEntity t_entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(t_entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t_entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(t_entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity t_entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(t_entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
