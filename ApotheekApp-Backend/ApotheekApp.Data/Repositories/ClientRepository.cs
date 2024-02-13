using ApotheekApp.Domain.Models;

namespace ApotheekApp.Data.Repositories
{
    public class ClientRepository
    {
        private readonly DataContext _dataContext;

        public ClientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            await _dataContext.AddAsync(client);
            return client;
        }

        public void DeleteClientAsync(int id)
        {
            Client? toDelete = _dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault();
            if (toDelete != null)
                _dataContext.Remove(toDelete);
        }

        public IEnumerable<Client> GetAllClients() => _dataContext.Set<Client>();

        public Client GetClientByIdAsync(int id) =>
            _dataContext.Set<Client>().Where(x => x.Id == id).FirstOrDefault() ?? throw new KeyNotFoundException();

        public Client GetClientByNameAsync(string lastname, DateTime dob, string? firstname)
        {
            if (firstname == "")
                return (Client)_dataContext.Set<Client>().Where(x => x.DateOfBirth == dob && x.LastName == lastname);

            return (Client)_dataContext.Set<Client>().Where(x => x.DateOfBirth == dob && x.LastName == lastname && x.Name == firstname);
        }

        public Client UpdateClientAsync(Client client)
        {
            _dataContext.Update(client);
            return client;
        }

        public async Task SaveChanges() => await _dataContext.SaveChangesAsync();
    }
}