using ApotheekApp.Data.Repositories;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            //ArgumentNullException.ThrowIfNull(client);
            await _clientRepository.CreateClientAsync(client);
            await _clientRepository.SaveChangesAsync();
            return client;
        }

        public async Task DeleteClientAsync(string id)
        {
            _clientRepository.DeleteClient(id);
            await _clientRepository.SaveChangesAsync();
        }

        public IEnumerable<Client> GetAllClients() => _clientRepository.GetAllClients();

        public async Task<Client?> GetClientByIdAsync(string id) => await _clientRepository.GetClientByIdAsync(id);

        public async Task<Client?> GetClientByNameAsync(string lastname, DateTime dob, string? firstname) =>
            await _clientRepository.GetClientByNameAsync(lastname, dob, firstname);

        public async Task<Client> UpdateClientAsync(Client client)
        {
            //ArgumentNullException.ThrowIfNull(client);
            _clientRepository.UpdateClient(client);
            await _clientRepository.SaveChangesAsync();
            return client;
        }
    }
}