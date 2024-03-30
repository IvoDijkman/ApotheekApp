using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionRepository
    {
        public Task<Prescription> CreatePrescriptionAsync(Prescription prescription);

        public Task SaveChangesAsync();

        public Task<Prescription> GetById(int id);
    }
}