using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IRepository<Medicine> _medicineRepository;

        public MedicineService(IRepository<Medicine> medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            return _medicineRepository.GetAll().ToList();
        }

        public async Task<Medicine> GetByIdAsync(int id)
        {
            return await _medicineRepository.GetByIdAsync(id) ?? throw new ArgumentException("Medicine Id not found");
        }

        public async Task Delete(int id)
        {
            await _medicineRepository.Delete(id);
        }
    }
}