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

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}