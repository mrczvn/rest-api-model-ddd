using System.Collections.Generic;

namespace rest_api_ddd.domain.core.interfaces.repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        void Add(TEntity obj);

        /// <summary>
        ///
        /// </summary> 
        /// <param name="obj"></param>
        void Update(TEntity obj);

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        void Remove(TEntity obj);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(int id);
    }
}