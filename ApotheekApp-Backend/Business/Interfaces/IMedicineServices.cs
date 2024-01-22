using Business.Objects;

namespace ApotheekApp.Business.Interfaces
{
    public interface IMedicineServices
    {
        IEnumerable<Medicine> GetAllAsync();
        IEnumerable<Medicine> GetAllByUserAsync(); // Appuser user (pass as parameter)
        IEnumerable<Medicine> GetByIdAsync(int id);
        Task Delete(int id); // Appuser user (pass as parameter) and id is id of medicine
    }
}
