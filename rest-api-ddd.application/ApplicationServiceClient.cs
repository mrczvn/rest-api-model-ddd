using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.domain.core.interfaces.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace rest_api_ddd.application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }
        public void Add(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListClientsDto(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MapperEntityToDto(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Update(client);
        }
    }
}
