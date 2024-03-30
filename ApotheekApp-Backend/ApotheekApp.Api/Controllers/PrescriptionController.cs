using ApotheekApp.Domain.Interfaces;
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

        [HttpPost("postprescription")]
        public async Task<IActionResult> PostPrescription()
        {
            try
            {
                await _prescriptionService.
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}