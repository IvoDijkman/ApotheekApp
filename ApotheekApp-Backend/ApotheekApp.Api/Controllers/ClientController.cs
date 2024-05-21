using ApotheekApp.Business.Services;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public IActionResult GetClients()
        {
            try
            {
                return Ok(_clientService.GetAllClients());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetClients(string clientId)
        {
            try
            {
                return Ok(_clientService.GetClientById(clientId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetClientsByName(string lastname, DateTime dob, string? firstname)
        {
            try
            {
                return Ok(_clientService.GetClientByName(lastname, dob, firstname));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(Client client)
        {
            try
            {
                if (client == null) { return BadRequest("No client was found."); }
                return Ok(await _clientService.CreateClientAsync(client));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClient(Client client)
        {
            try
            {
                return Ok(await _clientService.UpdateClientAsync(client));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(string id)
        {
            try
            {
                await _clientService.DeleteClientAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong, delete failed.");
            }
        }
    }
}