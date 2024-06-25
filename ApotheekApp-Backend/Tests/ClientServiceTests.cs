using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
        private Client _Client3;
        private Client _Client4;

        [Fact]
        private void Should_get_all_clients()
        {
            Assert.Equal(14, _service.GetAllClients().Count());
            //14 results because the seeding data is present in the test db due to inheritance.
        }

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
            Client? client = await _service.GetClientByNameAsync("TestLastName2", date, "");

            Assert.Equal("TestFirstName2", client?.FirstName);
        }

        [Fact]
        private async Task Should_find_a_client_by_name_first_and_last()
        {
            DateTime date = new(2000, 2, 2);
            Client? client = await _service.GetClientByNameAsync("TestLastName2", date, "TestFirstName2");

            Assert.Equal("TestFirstName2", client?.FirstName);
        }

        [Fact]
        private async Task Should_create_a_client()
        {
            Client newClient = new() { FirstName = "newtest", LastName = "newlasttest", DateOfBirth = new DateTime(1988, 7, 6), Id = "threeeeee" };
            await _service.CreateClientAsync(newClient);
            Client? compare = await _service.GetClientByIdAsync("threeeeee");
            Assert.Equal(compare?.Id, newClient.Id);
        }

        [Fact]
        private async Task Should_update_an_existing_client()
        {
            _Client3.FirstName = "updatedFirst";
            await _service.UpdateClientAsync(_Client3);
            Client? clientCheck = await _service.GetClientByIdAsync("kekeke");
            Assert.Equal(_Client3?.FirstName, clientCheck?.FirstName);
        }

        [Fact]
        private async Task Should_delete_the_client()
        {
            await _service.DeleteClientAsync("getnuked");
            Assert.Null(await _service.GetClientByIdAsync("getnuked"));
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
            _Client3 = new Client
            {
                FirstName = "TestFirstName3",
                LastName = "TestLastName3",
                Id = "kekeke",
                DateOfBirth = new DateTime(2006, 6, 6)
            };
            _Client4 = new Client
            {
                FirstName = "TestFirstName4",
                LastName = "TestLastName4",
                Id = "getnuked",
                DateOfBirth = new DateTime(1999, 8, 7)
            };
            context.Add(_Client);
            context.Add(_Client2);
            context.Add(_Client3);
            context.Add(_Client4);
            return Task.CompletedTask;
        }
    }
}