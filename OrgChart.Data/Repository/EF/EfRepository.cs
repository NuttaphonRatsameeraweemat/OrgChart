using Microsoft.EntityFrameworkCore;
using OrgChart.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Z.EntityFramework.Plus;

namespace OrgChart.Data.Repository.EF
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        #region [Fields]

        /// <summary>
        /// The database context that retrieved from entity framework for using in inherited class to modify.
        /// </summary>
        protected DbContext _context;
        /// <summary>
        /// The DbSet that retrieved from entity framework for using in inherited class to modify.
        /// </summary>
        protected DbSet<TEntity> _dbSet;

        #endregion

        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="EfRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public EfRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Inserts a data as poco entity to database.
        /// </summary>
        /// <param name="entity">The entity to insert.</param>
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Inserts the multiple data as collection of poco entities to database.
        /// </summary>
        /// <param name="entities">The collection of entities to insert.</param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        /// <summary>
        /// Gets poco entity representing data in database.
        /// </summary>
        /// <param name="filter">The filter data.</param>
        /// <param name="orderBy">The ordering data.</param>
        /// <param name="includeProperties">The collection of property names of related poco entity for including data.</param>
        /// <returns>Collection of data as IEnumerable of poco entity.</returns>
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includeProperties)
        {
            return GetQueryable(filter, orderBy, includeProperties).ToList();
        }

        /// <summary>
        /// Gets poco entity from cache representing data in database.
        /// </summary>
        /// <param name="filter">The filter data.</param>
        /// <param name="orderBy">The ordering data.</param>
        /// <param name="includeProperties">The collection of property names of related poco entity for including data.</param>
        /// <returns>Collection of data as IEnumerable of poco entity.</returns>
        public IEnumerable<TEntity> GetCache(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includeProperties)
        {
            return GetQueryable(filter, orderBy, includeProperties).FromCache(typeof(TEntity).Name).ToList();
        }

        /// <summary>
        /// Gets poco entity representing data in database by using primary key.
        /// </summary>
        /// <param name="id">The primary key.</param>
        /// <returns>A data as poco entity. It will be null if could not found data.</returns>
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Gets the amount of data with filter if any.
        /// </summary>
        /// <param name="filter">The filter data.</param>
        /// <returns>Amount of data.</returns>
        public int GetCount(Expression<Func<TEntity, bool>> filter = null)
        {
            // AsNoTracking, this optimization allows you to tell Entity Framework not to track the results of a query.
            IQueryable<TEntity> result = _dbSet;

            // For filter.
            if (filter != null)
            {
                result = result.Where(filter);
            }

            return result.Count();
        }

        /// <summary>
        /// Gets the query that allow outside to execute a query by them self, IQuery will not get data from database
        /// it will waiting when called methods that will the collection or object then will connect to database and get the data.
        /// </summary>
        /// <param name="filter">The filter data.</param>
        /// <param name="orderBy">The ordering data.</param>
        /// <param name="includeProperties">The collection of property names of related poco entity for including data.</param>
        /// <returns> <see cref="System.Linq.IQueryable"/> </returns>
        public IQueryable<TEntity> GetQueryable(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includeProperties)
        {
            IQueryable<TEntity> result = _dbSet;

            // For filter.
            if (filter != null)
            {
                result = result.Where(filter);
            }

            // For include properties.
            result = includeProperties.Aggregate(
                result,
                (current, includeProperty) => current.Include(includeProperty)
            );

            // Returns with checking ordering.
            return (orderBy != null) ? orderBy(result) : result;
        }

        /// <summary>
        /// Deletes a data by using primary key.
        /// </summary>
        /// <param name="id">The primary key.</param>
        public void Remove(int id)
        {
            TEntity entityToDelete = GetById(id);
            if (entityToDelete != null)
            {
                Remove(entityToDelete);
            }
        }

        /// <summary>
        /// Deletes a data as poco entity from database.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Deletes the multiple data as collection of poco entities from database.
        /// </summary>
        /// <param name="entities">The collection of entities to delete.</param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        /// <summary>
        /// Updates a data as poco entity in database.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        #endregion

    }
}
