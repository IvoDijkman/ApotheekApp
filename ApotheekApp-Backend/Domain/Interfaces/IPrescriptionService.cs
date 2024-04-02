using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionService
    {
        Task<Prescription> CreateAsync(Prescription prescription);

        Task<IEnumerable<Prescription>> GetAllAsync();

        Task<Prescription> GetByIdAsync(int id);

        Task ToggleIsCollectedAsync(int id);
    }
}