using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IClientRepository
    {
        public Task<Client> CreateClientAsync(Client client);

        public void DeleteClientAsync(string id);

        public IEnumerable<Client> GetAllClients();

        public Client GetClientByIdAsync(string id);

        public Client GetClientByNameAsync(string lastname, DateTime dob, string? firstname);

        public Client UpdateClientAsync(Client client);

        public Task SaveChanges();
    }
}