using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        [Route("CreateClientByName")]
        public async Task<IActionResult> CreateClient(string firstName, string lastName)
        {
            try
            {
                Client client = new Client() { FirstName = firstName, LastName = lastName };
                return Ok(await _clientService.CreateClientAsync(client));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost]
        [Route("CreateClient")]
        public async Task<IActionResult> CreateClient(Client client)
        {
            try
            {
                return Ok(await _clientService.CreateClientAsync(client));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet]
        [Route("GetAllCients")]
        public async Task<IActionResult> GetAllCients()
        {
            try
            {
                return Ok(await _clientService.GetAllClients());
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet]
        [Route("GetClientById")]
        public async Task<IActionResult> GetClientById(int id)
        {
            try
            {
                return Ok(await _clientService.GetClientByIdAsync(id));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        [Route("UpdateClient")]
        public async Task<IActionResult> UpdateClient(Client client)
        {
            try
            {
                return Ok(await _clientService.UpdateClientAsync(client));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}