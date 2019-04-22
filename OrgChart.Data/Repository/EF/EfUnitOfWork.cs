using Microsoft.EntityFrameworkCore;
using OrgChart.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChart.Data.Repository.EF
{
    public class EfUnitOfWork<TDbContext> : IUnitOfWork
        where TDbContext : DbContext
    {

        #region [Fields]

        /// <summary>
        /// The dispose flag.
        /// </summary>
        private bool _disposed = false;

        /// <summary>
        /// The database context that retrieved from entity framework for using in inherited class to modify.
        /// </summary>
        protected DbContext _context;

        /// <summary>
        /// Repositories's container that store the repositories to prevent to create new instance many times.
        /// </summary>
        protected Dictionary<string, dynamic> _repositoriesContainer = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public EfUnitOfWork(TDbContext context, bool lazyLoad = true)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

            // Initializes container.
            _repositoriesContainer = new Dictionary<string, dynamic>();
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Gets a repository by passing type of poco entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the poco entity.</typeparam>
        /// <returns>A repository as <see cref="IRepository{TEntity}"/> interface.</returns>
        /// <exception cref="System.ObjectDisposedException">When object has been disposed.</exception>
        public IRepository<TEntity> GetRepository<TEntity>()
           where TEntity : class
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }

            string pocoName = typeof(TEntity).Name;
            if (!_repositoriesContainer.ContainsKey(pocoName))
            {
                // Creates new Repository and store to private dictionary field.
                _repositoriesContainer.Add(pocoName, Activator.CreateInstance(typeof(EfRepository<>).MakeGenericType(typeof(TEntity)), _context));
            }

            // return respository that keep in container field.
            return _repositoriesContainer[pocoName] as IRepository<TEntity>;
        }

        /// <summary>
        /// Commit all changes by using repository to database.
        /// </summary>
        /// <returns>The number of objects written to the underlying database.</returns>
        /// <exception cref="System.ObjectDisposedException">When object has been disposed.</exception>
        public int Complete()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }
            return _context.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
        /// <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                if (_repositoriesContainer.Any())
                {
                    _repositoriesContainer.Clear();
                }

                _repositoriesContainer = null;
                _context.Dispose();
                _context = null;
            }

            _disposed = true;
        }

        #endregion

    }
}
