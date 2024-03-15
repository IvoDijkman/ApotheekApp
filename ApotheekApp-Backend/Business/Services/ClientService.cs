using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _clientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            ArgumentNullException.ThrowIfNull(client);
            //ToDo:do we search for NormalizedUserName?
            if (await _clientRepository.GetAll().AnyAsync(e => e.FirstName == client.FirstName))
            {
                throw new ArgumentException("Client allready exists");
            }
            await _clientRepository.CreateAsync(client);
            await _clientRepository.SaveChangesAsync();
            return client;
        }

        public async Task DeleteClientAsync(int id)
        {
            await _clientRepository.Delete(id);
            //await _clientRepository.SaveChangesAsync(); Todo: delete?
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _clientRepository.GetAll().ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            ArgumentNullException.ThrowIfNull(client);
            await _clientRepository.UpdateAsync(client);
            //await _clientRepository.SaveChangesAsync();Todo: delete?
            return client;
        }
    }
}