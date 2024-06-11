using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IClientRepository
    {
        /// <summary>
        /// Creates a new Client.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Client> CreateClientAsync(Client client);

        /// <summary>
        /// Deletes a Client using the id.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteClient(string id);

        /// <summary>
        /// Gets a list of all Clients.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client> GetAllClients();

        /// <summary>
        /// Searches for a Client by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Client?> GetClientById(string id);

        /// <summary>
        /// Search for a Client by lastname, dob, ?firstname.
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="dob"></param>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public Task<Client?> GetClientByNameAsync(string lastname, DateTime dob, string? firstname);

        /// <summary>
        /// Update an existing Client.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Client UpdateClient(Client client);

        /// <summary>
        /// Save changes to db.
        /// </summary>
        /// <returns></returns>
        public Task SaveChangesAsync();
    }
}