using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class ClientService : IClientService
    {
        public Task<Client> CreateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public Client GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Client GetClientByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> SearchClients(string query)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}