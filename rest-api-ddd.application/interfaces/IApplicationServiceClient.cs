using rest_api_ddd.domain.services;
using System.Collections.Generic;

namespace rest_api_ddd.application.interfaces
{
    public interface IApplicationServiceClient
    {   /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        void Add(ClientDto clientDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        void Update(ClientDto clientDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="clientDto"></param>
        void Remove(ClientDto clientDto);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<ClientDto> GetAll();

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClientDto GetById(int id);
    }
}