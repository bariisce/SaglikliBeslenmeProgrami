using System.Linq.Expressions;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.Repositories.Base;

public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
{
    protected readonly PostgresContext PostgresContext;
    
    protected Repository(PostgresContext postgresContext)
    {
        PostgresContext = postgresContext;
    }
    
    public virtual async Task AddAsync(TEntity entity)
    {
        await PostgresContext.Set<TEntity>().AddAsync(entity);
    }
    
    public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await PostgresContext.Set<TEntity>().AddRangeAsync(entities);
    }
    
    public virtual async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
    {
        var entity = await PostgresContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        return entity;
    }

    public virtual async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
    {
        return filter == null
            ? await PostgresContext.Set<TEntity>().ToListAsync()
            : await PostgresContext.Set<TEntity>().Where(filter).ToListAsync();
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await PostgresContext.Set<TEntity>().FirstOrDefaultAsync(filter);
    }
    
    public virtual async Task<TEntity> GetByIdAsync(TId id)
    {
        return await PostgresContext.Set<TEntity>().FindAsync(id);
    }
    
    public virtual async Task<int> GetCountAsync(Expression<Func<TEntity, bool>>? filter = null)
    {
        return filter == null
            ? await PostgresContext.Set<TEntity>().CountAsync()
            : await PostgresContext.Set<TEntity>().Where(filter).CountAsync();
    }
    public virtual async Task RemoveAsync(TEntity entity)
    {
        PostgresContext.Set<TEntity>().Remove(entity);
    }

    public async Task RemoveByIdAsync(TId id)
    {
        var entity = await PostgresContext.Set<TEntity>().FindAsync(id);

        if (entity != null)
        {
            await RemoveAsync(entity);
        }
    }

    public virtual void RemoveRange(IEnumerable<TEntity> entities)
    {
        PostgresContext.Set<TEntity>().RemoveRange(entities);
    }
    
    public virtual void UntrackEntity(TEntity entity)
    {
        PostgresContext.Entry(entity).State = EntityState.Detached;
    }
    
    public virtual void Update(TEntity entity)
    {
        PostgresContext.Set<TEntity>().Update(entity);
    }
    
    public virtual async Task UpdateAsync(TEntity entity)
    {
        PostgresContext.Set<TEntity>().Update(entity);
        await PostgresContext.SaveChangesAsync();
    }
    
    public virtual void UpdateRange(IEnumerable<TEntity> entities)
    {
        PostgresContext.Set<TEntity>().UpdateRange(entities);
    }
}