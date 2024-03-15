using ApotheekApp.Business.Services;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : BaseController
    {
        private readonly IMedicineService _medicineService;
        private readonly UserManager<Client> _userManager;

        public MedicineController(IMedicineService medicineService, UserManager<Client> userManager)
        {
            _medicineService = medicineService;
            _userManager = userManager;
        }

        [HttpGet("GetAll"), Authorize]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<Medicine>? medicines = await _medicineService.GetAllAsync();

            if (medicines == null) return BadRequest("No medicines found");

            return Ok(medicines);
        }

        /*
                [HttpGet("GetAllByClient"), Authorize]
                public async Task<IActionResult> GetAllByClient()
                {
                    Client? client = await _userManager.GetUserAsync(User);
                    if (client == null) return NotFound("Client not found!");

                    // Pass user as parameter
                    IEnumerable<Medicine>? medicines = await _medicineService.GetAllByClientAsync(client);

                    if (medicines == null) return BadRequest("No medicines found");

                    return Ok(medicines);
                }*/

        /*        [HttpGet("GetWarnings/{id}"), Authorize]
                public async Task<IActionResult> GetWarnings(int id)
                {
                    Medicine? medicine = await _medicineService.GetByIdAsync(id);
                    if (medicine == null) return BadRequest("No medicine found");

                    return Ok(medicine.Warnings);
                }*/

        [HttpDelete("Delete/{id}"), Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await _medicineService.Delete(id);

            return Ok();
        }
    }
}