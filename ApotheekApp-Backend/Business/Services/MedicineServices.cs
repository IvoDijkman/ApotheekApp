using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class MedicineServices : IMedicineServices
    {
        private IMedicineRepository _medicineRepository;
        public MedicineServices(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            IEnumerable<Medicine>? medicines = await _medicineRepository.GetAllAsync();
            return medicines;
        }
        public async Task<IEnumerable<Medicine>?> GetAllByUserAsync(AppUser user)
        {
            IEnumerable<Medicine>? medicines = await _medicineRepository.GetAllByUserAsync(user);
            return medicines;
        }

        public async Task<Medicine?> GetByIdAsync(int id)
        {
            Medicine? medicine = await _medicineRepository.GetByIdAsync(id);
            return medicine;
        }

        public async Task Delete(int id)
        {
            await _medicineRepository.Delete(id);
        }
    }
}
