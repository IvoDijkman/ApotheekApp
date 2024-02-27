using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly DataContext _context;
        public MedicineRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            Medicine? medicine = await _context.Medicines.FirstOrDefaultAsync(m => m.Id == id);

            if (medicine != null)
            {
                _context.Medicines.Remove(medicine);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            return await _context.Medicines.ToListAsync();
        }

        public async Task<IEnumerable<Medicine>?> GetAllByClientAsync(Client client)
        {
            return client.Medicines;
        }

        public async Task<Medicine?> GetByIdAsync(int id)
        {
            return await _context.Medicines.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}