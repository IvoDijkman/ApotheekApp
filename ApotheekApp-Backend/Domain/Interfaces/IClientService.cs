using Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IClientService
    {
        /// <summary>
        /// Get Clients by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client GetClientByIdAsync(int id);

        /// <summary>
        /// Get Clients by Client name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Client GetClientByNameAsync(string name);

        /// <summary>
        /// Create a new Client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Client> CreateClientAsync(Client client);

        /// <summary>
        /// Update an existing Client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Client> UpdateClientAsync(Client client);

        /// <summary>
        /// Search Clients
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IEnumerable<Client> SearchClients(string query);

        /// <summary>
        /// Get list of all Clients
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client> GetAllClients();

        /// <summary>
        /// Delete Client by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteClientAsync(int id);
    }
}
