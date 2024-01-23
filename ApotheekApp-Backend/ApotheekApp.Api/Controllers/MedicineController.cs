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
        private readonly IMedicineServices _medicineService;
        private readonly UserManager<AppUser> _userManager;
        public MedicineController(IMedicineServices medicineService, UserManager<AppUser> userManager)
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

        [HttpGet("GetAllByUser"), Authorize]
        public async Task<IActionResult> GetAllByUser()
        {
            Client currentUser = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound("User not found!");

            // Pass user as parameter
            IEnumerable<Medicine>? medicines = await _medicineService.GetAllByUserAsync(user);

            if (medicines == null) return BadRequest("No medicines found");


            return Ok(medicines);
        }

        [HttpGet("GetWarnings/{id}"), Authorize]
        public async Task<IActionResult> GetWarnings(int id)
        {
            Medicine? medicine = await _medicineService.GetByIdAsync(id);
            if (medicine == null) return BadRequest("No medicine found");

            return Ok(medicine.Warnings);
        }

        [HttpDelete("Delete/{id}"), Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await _medicineService.Delete(id);

            return Ok();
        }
    }
}
