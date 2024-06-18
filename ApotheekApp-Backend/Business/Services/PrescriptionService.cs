﻿using ApotheekApp.Domain.Interfaces;
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

        public async Task<Prescription> CreateAsync(Prescription prescription)
        {
            await _prescriptionRepository.CreatePrescriptionAsync(prescription);
            await _prescriptionRepository.SaveChangesAsync();
            return prescription;
        }

        public async Task<IEnumerable<Prescription>> GetAll() => _prescriptionRepository.GetAll().OrderBy(p => p.Id);

        public async Task<IEnumerable<Prescription>> GetAllOpenPrescriptions() => _prescriptionRepository.GetAll().Where(p => !p.IsCollected).OrderBy(p => p.Id);

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