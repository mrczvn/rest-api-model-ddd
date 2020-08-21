using rest_api_ddd.application.dtos;
using rest_api_ddd.domain.entitys;
using System.Collections.Generic;

namespace rest_api_ddd.infrastructure.cross_cutting.interfaces
{
    public interface IMapperClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        /// <returns></returns>
        Client MapperDtoToEntity(ClientDto clientDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="clients"></param>
        /// <returns></returns>
        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        /// <summary>
        ///
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        ClientDto MapperEntityToDto(Client client);
    }
}