using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            IEnumerable<Client> clients = _clientService.GetAllClients();
            if (clients == null) return BadRequest();
            return Ok(clients);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetClientById(string id) => Ok(await _clientService.GetClientByIdAsync(id));

        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> SearchClients(string lastName, DateTime dob, string? firstName)
        {
            return BadRequest("Not implemented");
        }

        //create
        [HttpPost]
        public async Task<IActionResult> CreateClient(Client client)
        {
            return BadRequest("Not implemented");
        }

        //update
        [HttpPut]
        public async Task<IActionResult> UpdateClient(Client client)
        {
            return BadRequest("Not implemented");
        }

        //delete
        [HttpDelete]
        public IActionResult DeleteClient(string id)
        {
            return BadRequest("Not implemented");
        }
    }
}