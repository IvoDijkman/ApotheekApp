using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class MedicineRepository(DataContext context) : IMedicineRepository
    {
        public async Task Delete(int id)
        {
            Medicine? medicine = await context.Medicines.FirstOrDefaultAsync(m => m.Id == id);

            if (medicine != null)
            {
                context.Medicines.Remove(medicine);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            return await context.Medicines.ToListAsync();
        }

        public async Task<IEnumerable<Medicine>?> GetAllByClientAsync(Client client)
        {
            return client.Medicines;
        }

        public async Task<Medicine?> GetByIdAsync(int id)
        {
            return await context.Medicines.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}