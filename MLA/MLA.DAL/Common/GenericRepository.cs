using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MLA.DAL.Common
{
  public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
  {
    private readonly RepoContext _context = new RepoContext();
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository()
    {
//      _context = context;
      _dbSet = _context.Set<TEntity>();
    }

    public IEnumerable<TEntity> GetAll()
    {
      return _dbSet.AsNoTracking().ToList();
    }

    public IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate)
    {
      return _dbSet.AsNoTracking().Where(predicate).ToList();
    }

    public TEntity GetById(Guid id)
    {
      return _dbSet.Find(id);
    }


    public void Create(TEntity item)
    {
      _dbSet.Add(item);
      _context.SaveChanges();
    }

    public void Update(TEntity item)
    {
      _context.Entry(item).State = EntityState.Modified;
      _context.SaveChanges();
    }

    public void Remove(TEntity item)
    {
      _dbSet.Remove(item);
      _context.SaveChanges();
    }
    public void Remove(Guid id)
    {
      Remove(GetById(id));
    }


    public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
    {
      return Include(includeProperties).ToList();
    }

    public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
      params Expression<Func<TEntity, object>>[] includeProperties)
    {
      var query = Include(includeProperties);
      return query.Where(predicate).ToList();
    }

    private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
    {
      IQueryable<TEntity> query = _dbSet.AsNoTracking();
      return includeProperties
        .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
    }
  }
}