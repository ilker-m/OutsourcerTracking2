using Microsoft.EntityFrameworkCore;
using OutsourceTrackingWorkerService.DataAccess.Scaffold.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OutsourceTrackingWorkerService.DataAccess.Repository
{
    public class GenericEFRepository<TEntity, TContext>
        where TEntity : class, IEntityWS, new()
        where TContext : ApplicationContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<IEntityWS>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
