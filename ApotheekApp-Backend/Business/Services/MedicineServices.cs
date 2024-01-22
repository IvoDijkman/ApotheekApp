using ApotheekApp.Business.Interfaces;
using Business.Objects;

namespace Business.Functions
{
    public class MedicineServices : IMedicineServices
    {
        public IEnumerable<Medicine> GetAllAsync()
        {
            // Return all medicine
            throw new NotImplementedException();
        }
        public IEnumerable<Medicine> GetAllByUserAsync() // Appuser user (pass as parameter)
        {
            // Return all medicine of a specific user based on id
            throw new NotImplementedException();
        }

        public IEnumerable<Medicine> GetByIdAsync(int id)
        {
            // Return medicine by id
            throw new NotImplementedException();
        }

        public Task Delete(int id) // Appuser user (pass as parameter)
        {
            // Delete medicine of a specific user based on id
            throw new NotImplementedException();
        }
    }
}
