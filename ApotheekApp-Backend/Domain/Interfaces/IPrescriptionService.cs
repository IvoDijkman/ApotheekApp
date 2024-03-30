using ApotheekApp.Domain.Dtos;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IPrescriptionService
    {
        Task<IEnumerable<PrescriptionDto>> GetAllAsync();

        Task<PrescriptionDto> GetByIdAsync(int id);

        Task ToggleIsCollectedAsync(int id);
    }
}