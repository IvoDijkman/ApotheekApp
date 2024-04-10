using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Data.Repositories
{
    public class ClientRepository(DataContext dataContext) : IClientRepository
    {
        public async Task<Client> CreateClientAsync(Client client)
        {
            await dataContext.AddAsync(client);
            return client;
        }

        public void DeleteClientAsync(string id)
        {
            Client? toDelete = dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault();
            if (toDelete != null)
                dataContext.Remove(toDelete);
        }

        public IEnumerable<Client> GetAllClients() => dataContext.Set<Client>();

        public Client GetClientById(string id) =>
            dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault() ?? throw new KeyNotFoundException();

        public Client GetClientByNameAsync(string lastname, DateTime dob, string? firstname)
        {
            if (firstname == "")
                return (Client)dataContext.Set<Client>().Where(x => x.DateOfBirth == dob && x.LastName == lastname);

            return (Client)dataContext.Set<Client>().Where(x => x.DateOfBirth == dob && x.LastName == lastname && x.FirstName == firstname);
        }

        public Client UpdateClientAsync(Client client)
        {
            dataContext.Update(client);
            return client;
        }

        public async Task SaveChanges() => await dataContext.SaveChangesAsync();
    }
}