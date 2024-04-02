using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : BaseController
    {
        private readonly IPrescriptionService _prescriptionService;

        public PrescriptionController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }

        [HttpPost]
        public async Task<IActionResult> PostPrescription(Prescription prescription)
        {
            try
            {
                return Ok(await _prescriptionService.CreateAsync(prescription));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPrescriptions()
        {
            try
            {
                return Ok(await _prescriptionService.GetAllAsync());
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllPrescriptions(int id)
        {
            try
            {
                return Ok(await _prescriptionService.GetByIdAsync(id));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}