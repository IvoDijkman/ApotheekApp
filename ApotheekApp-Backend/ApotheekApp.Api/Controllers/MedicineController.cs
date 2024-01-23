using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineServices _medicineService;
        public MedicineController(IMedicineServices medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            // Get user
            // If user null return error

            IEnumerable<Medicine> medicines = _medicineService.GetAllAsync();

            if (medicines.Count() < 1) return BadRequest("No medicines found");

            return Ok(medicines);
        }

        [HttpGet("GetAllByUser")]
        public async Task<IActionResult> GetAllByUser()
        {
            // Get user
            // If user null return error

            // Pass user as parameter
            IEnumerable<Medicine> medicines = _medicineService.GetAllByUserAsync();

            if (medicines.Count() < 1) return BadRequest("No medicines found");


            return Ok(medicines);
        }

        [HttpGet("GetWarnings/{id}")]
        public async Task<IActionResult> GetWarnings(int id)
        {
            // Get user
            // If user null return error

            // Pass user as parameter
            Medicine medicine = _medicineService.GetByIdAsync(id);
            if (medicine == null) return BadRequest("No medicine found");


            return Ok(medicine.Warnings);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // Get user
            // If user null return error

            // Pass user as parameter
            await _medicineService.Delete(id);

            return Ok();
        }
    }
}
