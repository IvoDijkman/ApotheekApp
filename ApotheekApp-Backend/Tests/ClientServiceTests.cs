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

        [Fact]
        private async Task Should_get_client_by_id()
        {
            Client? client = await _service.GetClientByIdAsync("yadayada");
            Assert.Equal("TestFirstName2", client?.FirstName);
        }

        [Fact]
        private async Task Should_find_a_client_by_name()
        {
            DateTime date = new(2000, 2, 2);
            Client? client = await _service.GetClientByNameAsync("TestLastName2", date, "TestFirstName2");

            Assert.Equal("TestFirstName2", client?.FirstName);
        }

        [Fact]
        private async Task Should_create_a_client()
        {
            Client newclient = new() { FirstName = "newtest", LastName = "newlasttest", DateOfBirth = new DateTime(1988, 7, 6), Id = "threeeeee" };
            await _service.CreateClientAsync(newclient);
            Client? compare = await _service.GetClientByIdAsync("threeeeee");
            Assert.Equal(compare?.Id, newclient.Id);
        }

        [Fact]
        private async Task Should_update_an_existing_client()
        {
        }

        [Fact]
        private void Should_get_all_Clients()
        {
            Assert.Equal(2, _service.GetAllClients().Count()); //this gives an incorrect count
        }

        [Fact]
        private async Task DeleteClientAsync()
        {
        }

        protected override Task SetupDatabase(DataContext context)
        {
            _Client = new Client
            {
                FirstName = "TestFirstName1",
                LastName = "TestLastName1",
                Id = "Blablabla",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
            _Client2 = new Client
            {
                FirstName = "TestFirstName2",
                LastName = "TestLastName2",
                Id = "yadayada",
                DateOfBirth = new DateTime(2000, 2, 2)
            };
            context.Add(_Client);
            context.Add(_Client2);
            return Task.CompletedTask;
        }
    }
}