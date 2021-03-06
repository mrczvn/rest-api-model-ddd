﻿using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.domain.entitys;
using System.Collections.Generic;
using System.Linq;

namespace rest_api_ddd.application.mappers
{
    public class MapperClient : IMapperClient
    {
        private IEnumerable<ClientDto> clientDtos = new List<ClientDto>();

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        /// <returns></returns>
        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                Surname = clientDto.Surname,
                Email = clientDto.Email
            };

            return client;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Name = client.Name,
                Surname = client.Surname,
                Email = client.Email
            };

            return clientDto;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="clients"></param>
        /// <returns></returns>
        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto { Id = c.Id, Name = c.Name, Surname = c.Surname, Email = c.Email });

            return dto;
        }
    }
}