using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Vehicle.Data;

namespace Vehicle.Business.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, new()
    {
        private VehicleDbContext _vehicleDbContext;

        #region Properties
        public EntityBaseRepository(VehicleDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }

        #endregion
        public virtual IEnumerable<T> GetAll()
        {
            return _vehicleDbContext.Set<T>().AsEnumerable();
        }

        public virtual int Count()
        {
            return _vehicleDbContext.Set<T>().Count();
        }
        public virtual IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _vehicleDbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsEnumerable();
        }

        //public T GetSingle(int id)
        //{
        //    return _vehicleDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        //}

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _vehicleDbContext.Set<T>().FirstOrDefault(predicate);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _vehicleDbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _vehicleDbContext.Set<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            EntityEntry dbEntityEntry = _vehicleDbContext.Entry<T>(entity);
            _vehicleDbContext.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            EntityEntry dbEntityEntry = _vehicleDbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            EntityEntry dbEntityEntry = _vehicleDbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _vehicleDbContext.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                _vehicleDbContext.Entry<T>(entity).State = EntityState.Deleted;
            }
        }

        public virtual void Commit()
        {
            _vehicleDbContext.SaveChanges();
        }
    }
}
