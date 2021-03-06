﻿using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.core.interfaces.services;
using rest_api_ddd.domain.entitys;

namespace rest_api_ddd.domain.services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
            : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}