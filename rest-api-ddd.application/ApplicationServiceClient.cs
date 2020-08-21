using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.domain.core.interfaces.services;
using System.Collections.Generic;

namespace rest_api_ddd.application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        /// <summary>
        ///
        /// </summary>
        /// <param name="serviceClient"></param>
        /// <param name="mapperClient"></param>
        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        public void Add(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Add(client);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListClientsDto(clients);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MapperEntityToDto(client);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        public void Remove(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Remove(client);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        public void Update(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Update(client);
        }
    }
}