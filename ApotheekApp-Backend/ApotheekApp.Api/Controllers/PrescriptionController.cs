using ApotheekApp.Domain.Dtos;
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

        [HttpPost("post")]
        public async Task<IActionResult> PostPrescription(PrescriptionDto prescriptionDto)
        {
            try
            {
                Prescription prescription = new() { ClientId = prescriptionDto.ClientId, Name = prescriptionDto.Name, Description = prescriptionDto.Description };
                return Ok(await _prescriptionService.CreateAsync(prescription));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllPrescriptions()
        {
            try
            {
                return Ok(await _prescriptionService.GetAllAsync());
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}