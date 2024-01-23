using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IMedicineService
    {
        IEnumerable<Medicine> GetAllAsync();

        IEnumerable<Medicine> GetAllByUserAsync(); // Appuser user (pass as parameter)

        Medicine GetByIdAsync(int id);

        Task Delete(int id); // Appuser user (pass as parameter) and id is id of medicine
    }
}