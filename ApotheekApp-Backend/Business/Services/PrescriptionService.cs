using ApotheekApp.Business.Extensions;
using ApotheekApp.Domain.Dtos;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionService(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public async Task<PrescriptionDto> CreateAsync(Prescription prescription)
        {
            await _prescriptionRepository.CreatePrescriptionAsync(prescription);
            await _prescriptionRepository.SaveChangesAsync();
            return prescription.MapToPrescriptionDto();
        }

        public async Task<IEnumerable<PrescriptionDto>> GetAllAsync()
        {
            List<PrescriptionDto> prescriptionDtos = new();
            var prescriptions = await _prescriptionRepository.GetAllAsync();
            foreach (Prescription prescription in prescriptions)
            {
                prescriptionDtos.Add(prescription.MapToPrescriptionDto());
            }
            return prescriptionDtos;
        }

        public async Task<PrescriptionDto> GetByIdAsync(int id)
        {
            Prescription prescription = await _prescriptionRepository.GetById(id);
            return prescription.MapToPrescriptionDto();
        }

        public async Task ToggleIsCollectedAsync(int id)
        {
            Prescription prescription = await _prescriptionRepository.GetById(id);
            prescription.IsCollected = !prescription.IsCollected;
            await _prescriptionRepository.SaveChangesAsync();
        }
    }
}