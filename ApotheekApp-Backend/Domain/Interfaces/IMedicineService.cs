using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IMedicineService
    {
        Task<IEnumerable<Medicine>?> GetAllAsync();

        Task<IEnumerable<Medicine>?> GetAllByClientAsync(Client client); // Appuser user (pass as parameter)

        Task<Medicine> GetByIdAsync(int id);

        Task Delete(int id); // Appuser user (pass as parameter) and id is id of medicine
    }
}