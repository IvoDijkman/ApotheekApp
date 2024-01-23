using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Business.Services
{
    public class ClientServices : IClientService
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