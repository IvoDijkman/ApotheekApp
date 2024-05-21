using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class ClientRepository(DataContext dataContext) : IClientRepository
    {
        public async Task<Client> CreateClientAsync(Client client)
        {
            await dataContext.AddAsync(client);
            return client;
        }

        public void DeleteClient(string id)
        {
            Client? toDelete = dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault();
            if (toDelete != null)
                dataContext.Remove(toDelete);
        }

        public IEnumerable<Client> GetAllClients() => dataContext.Set<Client>();

        public Client GetClientById(string id) =>
            dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault() ?? throw new KeyNotFoundException();

        public async Task<Client?> GetClientByName(string lastname, DateTime dob, string? firstname)
        {
            if (firstname == "")
                return await dataContext.Set<Client>().SingleOrDefaultAsync(x => x.DateOfBirth == dob && x.LastName == lastname);

            return await dataContext.Set<Client>().SingleOrDefaultAsync(x => x.DateOfBirth == dob && x.LastName == lastname && x.FirstName == firstname);
        }

        public Client UpdateClient(Client client)
        {
            dataContext.Update(client);
            return client;
        }

        public async Task SaveChangesAsync() => await dataContext.SaveChangesAsync();
    }
}