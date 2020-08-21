using Microsoft.EntityFrameworkCore;
using rest_api_ddd.domain.core.interfaces.repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace rest_api_ddd.infrastructure.data.repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        ///
        /// </summary>
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        public void Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        public void Remove(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        public void Update(TEntity obj)
        {
            sqlContext.Entry(obj).State = EntityState.Modified;
            sqlContext.SaveChanges();
        }
    }
}