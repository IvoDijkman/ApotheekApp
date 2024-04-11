using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Business.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionService(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public async Task<Prescription> CreateAsync(Prescription prescription)
        {
            await _prescriptionRepository.CreatePrescriptionAsync(prescription);
            await _prescriptionRepository.SaveChangesAsync();
            return prescription;
        }

        public async Task<IEnumerable<Prescription>> GetAllAsync() => await _prescriptionRepository.GetAll().OrderBy(p => p.Id).ToListAsync();

        public async Task<IEnumerable<Prescription>> GetAllOpenPrescriptionsAsync() => await _prescriptionRepository.GetAll().OrderBy(p => p.Id).Where(p => !p.IsCollected).ToListAsync();

        public async Task<Prescription> GetByIdAsync(int id)
        {
            Prescription prescription = await _prescriptionRepository.GetByIdAsync(id);
            return prescription;
        }

        public async Task<bool> ToggleIsCollectedAsync(int id)
        {
            Prescription prescription = await _prescriptionRepository.GetByIdAsync(id);
            prescription.IsCollected = !prescription.IsCollected;
            await _prescriptionRepository.SaveChangesAsync();
            return prescription.IsCollected;
        }
    }
}