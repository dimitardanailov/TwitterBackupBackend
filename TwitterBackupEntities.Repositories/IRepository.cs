using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBackupEntities.Repositories
{
    /// <summary>
    /// We will use IRepository to describe main database queries
    /// 
    /// <see cref="http://blog.sapiensworks.com/post/2012/03/05/The-Generic-Repository-Is-An-Anti-Pattern.aspx/"/>
    /// <see cref="https://irepository.codeplex.com/"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Get Record by record id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Create a new Item
        /// </summary>
        /// <param name="item"></param>
        void Create(T item);

        /// <summary>
        /// Update a record
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete item by Entity reference
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Delete item by id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
