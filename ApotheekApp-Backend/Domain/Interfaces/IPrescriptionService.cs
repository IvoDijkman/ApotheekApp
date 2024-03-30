using ApotheekApp.Domain.Dtos;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionService
    {
        Task<PrescriptionDto> CreateAsync(Prescription prescription);

        Task<IEnumerable<PrescriptionDto>> GetAllAsync();

        Task<PrescriptionDto> GetByIdAsync(int id);

        Task ToggleIsCollectedAsync(int id);
    }
}