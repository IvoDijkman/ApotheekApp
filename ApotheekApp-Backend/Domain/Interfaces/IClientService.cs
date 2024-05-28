using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IClientService
    {
        /// <summary>
        /// Get Clients by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client GetClientById(string id);

        /// <summary>
        /// Search Clients by lastname, dob and ?firstname.
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="dob"></param>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public Task<Client?> GetClientByNameAsync(string lastname, DateTime dob, string? firstname);

        /// <summary>
        /// Create a new Client.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Client> CreateClientAsync(Client client);

        /// <summary>
        /// Update an existing Client.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Client> UpdateClientAsync(Client client);

        /// <summary>
        /// Get list of all Clients.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client> GetAllClients();

        /// <summary>
        /// Delete Client by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteClientAsync(string id);
    }
}