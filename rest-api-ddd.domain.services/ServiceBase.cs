using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.core.interfaces.services;
using System;
using System.Collections.Generic;

namespace rest_api_ddd.domain.services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        /// <summary>
        ///
        /// </summary>
        /// <param name="repository"></param>
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}