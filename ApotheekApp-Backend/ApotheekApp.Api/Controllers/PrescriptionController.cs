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
        public async Task<IActionResult> Create(Prescription prescription)
        {
            try
            {
                return Ok(await _prescriptionService.CreateAsync(prescription));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _prescriptionService.GetAllAsync());
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet]
        [Route("open")]
        public async Task<IActionResult> GetAllOpen()
        {
            try
            {
                return Ok(await _prescriptionService.GetAllOpenPrescriptionsAsync());
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _prescriptionService.GetByIdAsync(id));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        [Route("toggle/{id}")]
        public async Task<IActionResult> ToggeleIsCollected(int id)
        {
            try
            {
                return Ok(await _prescriptionService.ToggleIsCollectedAsync(id));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}