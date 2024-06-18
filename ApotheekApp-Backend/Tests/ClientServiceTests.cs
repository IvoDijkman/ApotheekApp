using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApotheekApp.Tests
{
    [Collection("Database Tests")]
    public class ClientServiceTests : UnitTestBase<IClientService>
    {
        private Client _Client;
        private Client _Client2;

        //[Fact]
        //private Task<Client?> GetClientByIdAsync(string id);
        //[Fact]
        //private Task<Client?> GetClientByNameAsync(string lastname, DateTime dob, string? firstname);
        //[Fact]
        //private Task<Client> CreateClientAsync(Client client);
        //[Fact]
        //private Task<Client> UpdateClientAsync(Client client);
        //[Fact]
        //private IEnumerable<Client> GetAllClients();
        //[Fact]
        //private Task DeleteClientAsync(string id);
        protected override Task SetupDatabase(DataContext context)
        {
            _Client = new Client
            {
                FirstName = "TestFirstName1",
                LastName = "TestLastName1",
                Id = "Blablabla"
            };
            _Client2 = new Client
            {
                FirstName = "TestFirstName2",
                LastName = "TestLastName2",
                Id = "yadayada"
            };
            context.Add(_Client);
            context.Add(_Client2);
            return Task.CompletedTask;
        }
    }
}